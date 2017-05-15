using _2015147463_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463_PER.Repositories
{
  public   class UnityOfWork : IUnityOfWork
    {

        IAdministrativoRepository IUnityOfWork.Administrativo
        {
            get { throw new NotImplementedException(); }
        }

        IBusRepository IUnityOfWork.IBus
        {
            get { throw new NotImplementedException(); }
        }

        IClienteRepository IUnityOfWork.ICliente
        {
            get { throw new NotImplementedException(); }
        }

        IEmpleadoRepository IUnityOfWork.IEmpleado
        {
            get { throw new NotImplementedException(); }
        }

        ILugarViajeRepository IUnityOfWork.Ilugarviaje
        {
            get { throw new NotImplementedException(); }
        }

        IEncomiendaRepository IUnityOfWork.IEncomienda
        {
            get { throw new NotImplementedException(); }
        }

        IServiceProvider IUnityOfWork.IServicio
        {
            get { throw new NotImplementedException(); }
        }

        ITipoComprobanteRepository IUnityOfWork.ItipoComprobante
        {
            get { throw new NotImplementedException(); }
        }

        ITipoLugarRepository IUnityOfWork.ItIpoLugar
        {
            get { throw new NotImplementedException(); }
        }

        ITipoPagoRepository IUnityOfWork.ItIpoPago
        {
            get { throw new NotImplementedException(); }
        }

        ITipoTripulacionRepository IUnityOfWork.ItipoTripulacion
        {
            get { throw new NotImplementedException(); }
        }

        ITipoViajeRepository IUnityOfWork.ItipoViaje
        {
            get { throw new NotImplementedException(); }
        }

        ITransporteRepository IUnityOfWork.Itransporte
        {
            get { throw new NotImplementedException(); }
        }

        ITripulacionRepository IUnityOfWork.Itripulacion
        {
            get { throw new NotImplementedException(); }
        }

        IVentaRepository IUnityOfWork.Iventa
        {
            get { throw new NotImplementedException(); }
        }

        int IUnityOfWork.SaveChange()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
