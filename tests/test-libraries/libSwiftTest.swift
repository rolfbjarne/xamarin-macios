import Foundation

@objc(SwiftTestClass)
@available(iOS 13, tvOS 13, macOS 11, macCatalyst 13, *)
public class SwiftTestClass : NSObject {
    @objc
    // encoding for 'message': @"NSString"
    public func DoSomething(message: String) -> String {
        return message
    }

    @objc
    // encoding for 'message': @"NSString"
    // objc encoding for implicit callback: @?<v@?@"NSString">
    public func DoSomethingAsync(message: String) async -> String {
        do {
            try await Task.sleep(nanoseconds: 1)
        } catch {}
        return message;
    }

    @objc
    // objc encoding for 'message': @"NSString"
    // objc encoding for 'complexParameter': @?<@"NSString"@?@?<q@?s>>
    //  in particular this argument has nested <<>>
    // objc encoding for implicit callback: @?<v@?@"NSString">
    public func DoSomethingComplexAsync(message: String, complexParameter: @escaping ((Int16) -> Int64) -> String?) async -> String {
        do {
            try await Task.sleep(nanoseconds: 1)
        } catch {}
        return message;
    }
}
