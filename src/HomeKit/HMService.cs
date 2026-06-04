#nullable enable

using System.Threading.Tasks;

namespace HomeKit {

	public partial class HMService {

#if !TVOS
		/// <param name="serviceType">The service type.</param>
		///         <param name="completion">The completion.</param>
		///         <summary>Specifies that the device attached to a switch or outlet is of type <paramref name="serviceType" />. After the system sets the association, the system runs <paramref name="completion" />.</summary>
		public void UpdateAssociatedServiceType (HMServiceType serviceType, Action<NSError> completion)
		{
			UpdateAssociatedServiceType (serviceType.GetConstant (), completion);
		}

		/// <param name="serviceType">The service type.</param>
		///         <summary>Asynchronously updates the associated service type to  <paramref name="serviceType" /></summary>
		public Task UpdateAssociatedServiceTypeAsync (HMServiceType serviceType)
		{
			return UpdateAssociatedServiceTypeAsync (serviceType.GetConstant ());
		}
#endif
	}
}
