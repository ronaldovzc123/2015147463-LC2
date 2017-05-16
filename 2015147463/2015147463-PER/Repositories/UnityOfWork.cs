using _2015147463_ENT;
using _2015147463_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463_PER.Repositories
{
  public class UnityOfWork : IUnityOfWork
    {
      private readonly Class Context;
      private static UnityOfWork _Instance;
      private static readonly object Lock = new object();

      IAdministrativoRepository Administrativo { get; set; }
      IBusRepository Bus { get;  set; }
      IClienteRepository Cliente { get;  set; }
      IEmpleadoRepository Empleado { get;  set; }
      ILugarViajeRepository lugarviaje { get;  set; }
      IEncomiendaRepository Encomienda { get;  set; }
      IServiceProvider Servicio { get;  set; }
      ITipoComprobanteRepository TipoComprobante { get;  set; }
      ITipoLugarRepository TipoLugar { get;  set; }
      ITipoPagoRepository TitpoPago { get;  set; }
      ITipoTripulacionRepository TipoTripulacion { get;  set; }
      ITipoViajeRepository TipoViaje { get;  set; }
      ITransporteRepository Transporte { get;  set; }
      ITripulacionRepository Tripulacion { get;  set; }
      IVentaRepository Iventa { get;  set; }

        private  UnityOfWork()
        {
            Context = new Class();

            Administrativo = new AdministrativoRepository(Context);
            Cliente = new ClienteRepository(Context);
            Empleado = new EmpleadoRepository(Context);
            lugarviaje = new LugarViajeRepository(Context);
            Encomienda = new EncomiendaRepository(Context);
          //  Servicio = new ServicioRepository(Context);
            TipoComprobante = new TipoComprobanteRepository(Context);
            TipoLugar = new TipoLugarRepository(Context);
            TitpoPago = new TipoPagoRepository(Context);
            TipoTripulacion = new TipoTripulacionRepository(Context);
            TipoViaje = new TipoViajeRepository(Context);
            Transporte = new TransporteRepository(Context);
            Tripulacion = new TripulacionRepository(Context);
            //Iventa = new IVentaRepository(Context);
            Bus = new BusRepository(Context);

        }
        public static UnityOfWork Instance
        {
            get
            { 
                lock(Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }

                return _Instance;
 
            }
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

      public  int SaveChange()
        {
           return Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
