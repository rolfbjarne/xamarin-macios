#!/bin/bash
# Copyright (c) Microsoft Corporation.
# Licensed under the MIT License.

# profile-bgen.sh - Profile bgen (binding generator) for performance analysis
#
# Usage:
#   ./profile-bgen.sh              # Profile tvOS (fastest platform)
#   ./profile-bgen.sh --cpu        # CPU sampling profile only
#   ./profile-bgen.sh --memory     # GC/allocation profile only
#   ./profile-bgen.sh --gcdump     # Collect GC heap dump
#   ./profile-bgen.sh --time-only  # Just time the run (no tracing overhead)
#   ./profile-bgen.sh --validate   # Run all platforms and check git diff
#   ./profile-bgen.sh --platform ios  # Profile a specific platform

set -e

SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"
SRC_DIR="$SCRIPT_DIR/src"
BGEN_DLL="$SRC_DIR/build/dotnet/bgen/bgen.dll"
DOTNET="$SCRIPT_DIR/builds/downloads/$(ls "$SCRIPT_DIR/builds/downloads/" | grep dotnet-sdk | head -1)/dotnet"
OUTPUT_DIR="$SCRIPT_DIR/profile-output"

# Defaults
PROFILE_MODE="all"  # cpu, memory, gcdump, time-only, all, validate
PLATFORM="tvos"

usage() {
    echo "Usage: $0 [OPTIONS]"
    echo ""
    echo "Profile bgen for performance analysis."
    echo ""
    echo "Options:"
    echo "  --cpu            CPU sampling profile only"
    echo "  --memory         GC/allocation profile only (gc-verbose)"
    echo "  --gcdump         Collect GC heap dump mid-execution"
    echo "  --time-only      Just time the run (no tracing overhead)"
    echo "  --validate       Run all platforms and check for output changes"
    echo "  --platform NAME  Platform to profile (ios, tvos, macos, maccatalyst)"
    echo "                   Default: tvos (fastest)"
    echo "  --build          Rebuild bgen before profiling"
    echo "  --help           Show this help"
    echo ""
    echo "Output goes to: $OUTPUT_DIR/"
    exit 0
}

DO_BUILD=false

while [[ $# -gt 0 ]]; do
    case "$1" in
        --cpu) PROFILE_MODE="cpu"; shift ;;
        --memory) PROFILE_MODE="memory"; shift ;;
        --gcdump) PROFILE_MODE="gcdump"; shift ;;
        --time-only) PROFILE_MODE="time-only"; shift ;;
        --validate) PROFILE_MODE="validate"; shift ;;
        --platform) PLATFORM="$2"; shift 2 ;;
        --build) DO_BUILD=true; shift ;;
        --help|-h) usage ;;
        *) echo "Unknown option: $1"; usage ;;
    esac
done

# Validate platform
case "$PLATFORM" in
    ios|tvos|macos|maccatalyst) ;;
    *) echo "Error: Invalid platform '$PLATFORM'. Must be ios, tvos, macos, or maccatalyst."; exit 1 ;;
esac

# Check prerequisites
if [[ ! -f "$BGEN_DLL" ]]; then
    echo "Error: bgen not built. Run 'make -C src bgen' or pass --build."
    exit 1
fi

if [[ ! -f "$DOTNET" ]]; then
    echo "Error: dotnet SDK not found at $DOTNET"
    exit 1
fi

RSP_FILE="$SRC_DIR/build/dotnet/$PLATFORM/$PLATFORM.rsp"
if [[ ! -f "$RSP_FILE" ]]; then
    echo "Error: RSP file not found: $RSP_FILE"
    echo "Run a full build first (cb) to generate the RSP files."
    exit 1
fi

# Rebuild bgen if requested
if [[ "$DO_BUILD" == "true" ]]; then
    echo "=== Building bgen ==="
    make -C "$SRC_DIR" bgen
    echo ""
fi

mkdir -p "$OUTPUT_DIR"

# Helper: run bgen and time it
run_bgen_timed() {
    local label="$1"
    echo "=== Running bgen for $PLATFORM ($label) ==="
    local start_time end_time elapsed
    start_time=$(date +%s)

    # Run from src/ directory since RSP paths are relative to it
    (cd "$SRC_DIR" && "$@" )

    end_time=$(date +%s)
    elapsed=$((end_time - start_time))
    echo ""
    echo "=== $label completed in ${elapsed}s ==="
    echo ""
}

# CPU sampling profile
profile_cpu() {
    local trace_file="$OUTPUT_DIR/bgen-${PLATFORM}-cpu-$(date +%Y%m%d-%H%M%S).nettrace"
    echo "=== CPU Sampling Profile ==="
    echo "Output: $trace_file"
    echo ""

    (cd "$SRC_DIR" && \
        dotnet-trace collect \
            --profile cpu-sampling \
            --output "$trace_file" \
            --format NetTrace \
            -- "$DOTNET" "$BGEN_DLL" @"build/dotnet/$PLATFORM/$PLATFORM.rsp"
    )

    echo ""
    echo "=== CPU trace saved to: $trace_file ==="
    echo "Open with: dotnet-trace convert $trace_file --format Speedscope"
    echo ""
}

# GC/allocation profile
profile_memory() {
    local trace_file="$OUTPUT_DIR/bgen-${PLATFORM}-gc-$(date +%Y%m%d-%H%M%S).nettrace"
    echo "=== GC/Allocation Profile (gc-verbose) ==="
    echo "Output: $trace_file"
    echo ""

    (cd "$SRC_DIR" && \
        dotnet-trace collect \
            --profile gc-verbose \
            --output "$trace_file" \
            --format NetTrace \
            -- "$DOTNET" "$BGEN_DLL" @"build/dotnet/$PLATFORM/$PLATFORM.rsp"
    )

    echo ""
    echo "=== GC trace saved to: $trace_file ==="
    echo "Open with: dotnet-trace convert $trace_file --format Speedscope"
    echo ""
}

# GC dump (heap snapshot)
profile_gcdump() {
    if ! command -v dotnet-gcdump &>/dev/null; then
        echo "Error: dotnet-gcdump not installed."
        echo "Install with: dotnet tool install -g dotnet-gcdump"
        exit 1
    fi

    local dump_file="$OUTPUT_DIR/bgen-${PLATFORM}-heap-$(date +%Y%m%d-%H%M%S).gcdump"
    echo "=== GC Heap Dump ==="
    echo "Output: $dump_file"
    echo ""
    echo "Starting bgen in background, will trigger GC dump after 30s..."

    # Start bgen in background
    (cd "$SRC_DIR" && "$DOTNET" "$BGEN_DLL" @"build/dotnet/$PLATFORM/$PLATFORM.rsp") &
    local bgen_pid=$!

    # Wait a bit for bgen to get into the meat of its work
    sleep 30

    if kill -0 $bgen_pid 2>/dev/null; then
        echo "Collecting GC dump from PID $bgen_pid..."
        dotnet-gcdump collect -p $bgen_pid -o "$dump_file"
        echo ""
        echo "=== GC dump saved to: $dump_file ==="

        # Wait for bgen to finish
        wait $bgen_pid 2>/dev/null || true
    else
        echo "bgen already finished before dump could be taken."
        echo "Try a larger platform (--platform ios) for longer runtime."
    fi
    echo ""
}

# Time-only run (no profiling overhead)
profile_time_only() {
    echo "=== Timing Run (no profiling overhead) ==="
    echo "Platform: $PLATFORM"
    echo ""

    local start_time end_time elapsed
    start_time=$(python3 -c "import time; print(time.time())")

    local output
    output=$(cd "$SRC_DIR" && BGEN_REPORT_ALLOCATIONS=1 /usr/bin/time -l "$DOTNET" "$BGEN_DLL" @"build/dotnet/$PLATFORM/$PLATFORM.rsp" 2>&1)

    end_time=$(python3 -c "import time; print(time.time())")
    elapsed=$(python3 -c "print(f'{$end_time - $start_time:.2f}')")

    local peak_rss alloc_bytes
    peak_rss=$(echo "$output" | grep "maximum resident set size" | awk '{print $1}')
    alloc_bytes=$(echo "$output" | grep "BGEN_ALLOCATIONS:" | sed 's/.*: \([0-9]*\) bytes.*/\1/')

    echo ""
    echo "=== Results ==="
    echo "  Wall clock:       ${elapsed}s"
    if [ -n "$peak_rss" ]; then
        echo "  Peak RSS:         $((peak_rss / 1024 / 1024)) MB ($peak_rss bytes)"
    fi
    if [ -n "$alloc_bytes" ]; then
        echo "  Total allocated:  $((alloc_bytes / 1024 / 1024)) MB ($alloc_bytes bytes)"
    fi
    echo ""
}

# Validate all platforms (check generated code hasn't changed)
validate_all() {
    echo "=== Validating All Platforms ==="
    echo "Running bgen for all platforms and checking for output changes..."
    echo ""

    local all_ok=true
    for plat in tvos ios macos maccatalyst; do
        echo "--- $plat ---"
        local start_time end_time elapsed
        start_time=$(python3 -c "import time; print(time.time())")

        (cd "$SRC_DIR" && "$DOTNET" "$BGEN_DLL" @"build/dotnet/$plat/$plat.rsp")

        end_time=$(python3 -c "import time; print(time.time())")
        elapsed=$(python3 -c "print(f'{$end_time - $start_time:.2f}')")
        echo "  Completed in ${elapsed}s"

        # Check for changes in generated code
        local diff_output
        diff_output=$(git -C "$SCRIPT_DIR" diff --stat -- "src/build/dotnet/$plat/generated-sources/" 2>/dev/null || true)
        if [[ -n "$diff_output" ]]; then
            echo "  ❌ GENERATED CODE CHANGED!"
            echo "$diff_output" | head -10
            all_ok=false
        else
            echo "  ✅ Generated code unchanged"
        fi
        echo ""
    done

    if [[ "$all_ok" == "true" ]]; then
        echo "=== All platforms validated successfully ✅ ==="
    else
        echo "=== VALIDATION FAILED ❌ - Generated code changed! ==="
        echo "Run 'git diff -- src/build/dotnet/*/generated-sources/' to see details."
        exit 1
    fi
}

# Main dispatch
case "$PROFILE_MODE" in
    cpu)
        profile_cpu
        ;;
    memory)
        profile_memory
        ;;
    gcdump)
        profile_gcdump
        ;;
    time-only)
        profile_time_only
        ;;
    validate)
        validate_all
        ;;
    all)
        profile_time_only
        profile_cpu
        profile_memory
        ;;
esac
