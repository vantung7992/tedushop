using System;

namespace TeduShop.Data.Infastructure
{
    public class Disposeable : IDisposable
    {
        private bool isDisposeable;

        ~Disposeable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposeable && disposing)
            {
                DisposeCore();
            }
            isDisposeable = false;
        }

        protected virtual void DisposeCore()
        {
        }
    }
}