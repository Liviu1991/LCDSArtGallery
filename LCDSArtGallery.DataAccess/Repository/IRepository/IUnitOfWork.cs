using System;
using System.Collections.Generic;
using System.Text;

namespace LCDSArtGallery.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IProductTypeRepository ProductType { get; }
        IArtistRepository Artist { get; }
        IProductRepository Product { get; }
        IApplicationUserRepository ApplicationUser { get; }

        void Save();
    }
}
