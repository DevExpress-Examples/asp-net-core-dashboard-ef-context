using DevExpress.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace WebEFCoreApp {
    public class CustomEFContextProvider : IEFContextProvider, IDisposable {
        IServiceScope scope;
        public CustomEFContextProvider(IServiceProvider provider) {
            this.scope = provider.CreateScope();
        }
        public object GetContext(string connectionName, Type contextType) {
            // Returns the context for the specified `EFDataSource.ConnectionName`. 
            if (connectionName == "EF Data Connection") {
                return scope.ServiceProvider.GetRequiredService(contextType);
            }
            return null;
        }
        public void Dispose() {
            scope.Dispose();
        }
    }

}
