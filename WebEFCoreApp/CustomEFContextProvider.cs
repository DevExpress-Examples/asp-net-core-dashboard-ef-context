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
            if (connectionName == "EF Data Connection") {
                return scope.ServiceProvider.GetService(contextType);
            }
            return null;
        }
        public void Dispose() {
            scope.Dispose();
        }
    }

}
