using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terminal.DataAccess.Repository;
using Terminal.Entities.Entities;

namespace Terminal.BusinessLogic.Services
{
    public class TerminalService
    {
        private readonly ClientesRepository _clientesRepository;
        private readonly CargosRepository _cargosRepository;
        private readonly TerminalesRepository _terminalesRepository;
        private readonly HorariosRepository _horariosRepository;
        private readonly BoletosRepository _boletosRepository;
        private readonly CompañiaRepository _compañiaRepository;
        private readonly EmpleadoRepository _empleadoRepository;

        public TerminalService(ClientesRepository clientesRepository, CargosRepository cargosRepository, TerminalesRepository terminalesRepository, 
            HorariosRepository horariosRepository, BoletosRepository boletosRepository, CompañiaRepository compañiaRepository, EmpleadoRepository empleadoRepository)
        {
            _clientesRepository = clientesRepository;
            _cargosRepository = cargosRepository;
            _terminalesRepository = terminalesRepository;
            _horariosRepository = horariosRepository;
            _boletosRepository = boletosRepository;
            _compañiaRepository = compañiaRepository;
            _empleadoRepository = empleadoRepository;
        }

        #region Clientes
        public IEnumerable<VW_tbClientes> ListadoClientes()
        {
            try
            {
                return _clientesRepository.List();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_tbClientes>();
            }
        }
        public ServiceResult InsertarCliente(tbClientes item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _clientesRepository.Insert(item);
                return result.Ok(map);
                //if (map.CodeStatus > 0)
                //{

                //}
                //else
                //{ 
                //    map.MessageStatus = (map.CodeStatus == 0) ? "404 Error de consulta" : map.MessageStatus;
                //    return result.Error(map);
                //}

            }
            catch (Exception)
            {

                throw;
            }
        }
        public VW_tbClientes BuscarCliente(int id)
        {
            try
            {
                return _clientesRepository.Find(id);
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public RequestStatus BorrarCliente(int id)
        {
            try
            {
                return _clientesRepository.Delete(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RequestStatus UpdateCliente(tbClientes clientes)
        {
            try
            {
                return _clientesRepository.Update(clientes);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion

        #region Cargos

        
        public IEnumerable<VW_tbCargos> ListadoCargos()
        {
            try
            {
                return _cargosRepository.List();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_tbCargos>();
            }
        }
        public ServiceResult InsertarCargo(tbCargos item)
        {
            var result = new ServiceResult();
            try
            {
                var insert = _cargosRepository.Insert(item);
                if(insert.MessageStatus == "Registro agregado exitosamente")
                {
                    return result.Ok(insert.MessageStatus);
                }else if (insert.MessageStatus == "Ya existe un cargo con ese nombre")
                {
                    return result.Conflict(insert.MessageStatus);
                }
                else
                {
                    return result.SetMessage("Ha ocurrido un error", ServiceResultType.Conflict);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public VW_tbCargos BuscarCargos(int id)
        {
            try
            {
                return _cargosRepository.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RequestStatus BorrarCargo(int id)
        {
            try
            {
                return _cargosRepository.Delete(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RequestStatus UpdateCargos(tbCargos cargos)
        {
            try
            {
                return _cargosRepository.Update(cargos);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion

        #region Terminales

        public IEnumerable<VW_tbTerminales> ListadoTerminales()
        {
            try
            {
                return _terminalesRepository.List();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_tbTerminales>();
            }
        }
        public ServiceResult InsertarTerminal(tbTerminales item)
        {
            var result = new ServiceResult();
                try
                {
                    var insert =  _terminalesRepository.Insert(item);
                    if (insert.MessageStatus == "Registro agregado exitosamente")
                    {
                        return result.Ok(insert.MessageStatus);
                    }
                    else if (insert.MessageStatus == "A ocurrido un Error!!!")
                    {
                        return result.Conflict(insert.MessageStatus);
                    }
                    else
                    {
                        return result.SetMessage("Ha ocurrido un error", ServiceResultType.Conflict);
                    }

                }
                catch (Exception)
                {

                    throw;
                }
        }
        public VW_tbTerminales BuscarTerminales(int id)
        {
            try
            {
                return _terminalesRepository.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public ServiceResult BorrarTerminales(int id)
        {

            var result = new ServiceResult();

            try
            {
                var delete =  _terminalesRepository.Delete(id);
                if (delete.MessageStatus == "Registro agregado exitosamente")
                {
                    return result.Ok(delete.MessageStatus);
                }
                else if (delete.MessageStatus == "A ocurrido un Error!!!")
                {
                    return result.Conflict(delete.MessageStatus);
                }
                else
                {
                    return result.SetMessage("Ha ocurrido un error", ServiceResultType.Conflict);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public ServiceResult UpdateTerminales(tbTerminales terminales)
        {
            var result = new ServiceResult();
            try
            {
                var Update = _terminalesRepository.Update(terminales);
                if (Update.MessageStatus == "Registro agregado exitosamente")
                {
                    return result.Ok(Update.MessageStatus);
                }
                else if (Update.MessageStatus == "A ocurrido un Error!!!")
                {
                    return result.Conflict(Update.MessageStatus);
                }
                else
                {
                    return result.SetMessage("Ha ocurrido un error", ServiceResultType.Conflict);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion

        #region Horarios

        public IEnumerable<VW_tbHorarios> ListadoHorarios()
        {
            try
            {
                return _horariosRepository.List();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_tbHorarios>();
            }
        }
        public ServiceResult InsertarHorario(tbHorarios item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _horariosRepository.Insert(item);
                 
                 if (map.MessageStatus == "Registro agregado exitosamente")
                {
                    return result.Ok(map.MessageStatus);
                }
                else if (map.MessageStatus == "A ocurrido un Error!!!")
                {
                    return result.Conflict(map.MessageStatus);
                }
                else
                {
                    return result.SetMessage("Ha ocurrido un error", ServiceResultType.Conflict);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public VW_tbHorarios BuscarHorarios(int id)
        {
            try
            {
                return _horariosRepository.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public ServiceResult BorrarHorarios(int id)
        {
            var result = new ServiceResult();

            try
            {
                var delete =  _horariosRepository.Delete(id);
                 if (delete.MessageStatus == "Registro agregado exitosamente")
                {
                    return result.Ok(delete.MessageStatus);
                }
                else if (delete.MessageStatus == "A ocurrido un Error!!!")
                {
                    return result.Conflict(delete.MessageStatus);
                }
                else
                {
                    return result.SetMessage("Ha ocurrido un error", ServiceResultType.Conflict);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public ServiceResult UpdateHorarios(tbHorarios horarios)
        {
            var result = new ServiceResult();

            try
            {
                var update = _horariosRepository.Update(horarios);
                if (update.MessageStatus == "Registro agregado exitosamente")
                {
                    return result.Ok(update.MessageStatus);
                }
                else if (update.MessageStatus == "A ocurrido un Error!!!")
                {
                    return result.Conflict(update.MessageStatus);
                }
                else
                {
                    return result.SetMessage("Ha ocurrido un error", ServiceResultType.Conflict);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion

        #region Horarios

        public IEnumerable<VW_tbBoletos> ListadoBoletos()
        {
            try
            {
                return _boletosRepository.List();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_tbBoletos>();
            }
        }

        public ServiceResult InsertarBoletos(tbBoletos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _boletosRepository.Insert(item);
                if (map.MessageStatus == "Registro agregado exitosamente")
                {
                    return result.Ok(map.MessageStatus);
                }
                else if (map.MessageStatus == "A ocurrido un Error!!!")
                {
                    return result.Conflict(map.MessageStatus);
                }
                else
                {
                    return result.SetMessage("Ha ocurrido un error", ServiceResultType.Conflict);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public VW_tbBoletos BuscarBoletos(int id)
        {
            try
            {
                return _boletosRepository.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public ServiceResult BorrarBoletos(int id)
        {
            var result = new ServiceResult();

            try
            {
                var delete = _boletosRepository.Delete(id);
                if (delete.MessageStatus == "Registro agregado exitosamente")
                {
                    return result.Ok(delete.MessageStatus);
                }
                else if (delete.MessageStatus == "A ocurrido un Error!!!")
                {
                    return result.Conflict(delete.MessageStatus);
                }
                else
                {
                    return result.SetMessage("Ha ocurrido un error", ServiceResultType.Conflict);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public ServiceResult UpdateBoletos(tbBoletos boletos)
        {
            var result = new ServiceResult();

            try
            {
                var update = _boletosRepository.Update(boletos);

                if (update.MessageStatus == "Registro agregado exitosamente")
                {
                    return result.Ok(update.MessageStatus);
                }
                else if (update.MessageStatus == "A ocurrido un Error!!!")
                {
                    return result.Conflict(update.MessageStatus);
                }
                else
                {
                    return result.SetMessage("Ha ocurrido un error", ServiceResultType.Conflict);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion

        #region ddls

        public IEnumerable<tbDepartamentos> LoadDepartamento()
        {
            try
            {
                return _terminalesRepository.LoadDepartamento();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<tbDepartamentos>();
            }
        }

        public IEnumerable<tbMunicipios> LoadMunicipio(string id)
        {
            try
            {
                return _terminalesRepository.LoadMunicipio(id);
            }
            catch (Exception e)
            {

                return Enumerable.Empty<tbMunicipios>();
            }
        }

        public IEnumerable<VW_graficaViaje> LoadTrips()
        {
            try
            {
                return _boletosRepository.LoadTrips();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_graficaViaje>();
            }
        }

        public IEnumerable<VW_graficaSexo> LoadSex()
        {
            try
            {
                return _boletosRepository.LoadSex();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_graficaSexo>();
            }
        }
        #endregion

        #region Compañia
        public IEnumerable<tbCompania> ListadoCompania()
        {
            try
            {
                return _compañiaRepository.List();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<tbCompania>();
            }
        }
        #endregion

        #region Empleado
        public IEnumerable<VW_tbEmpleados> ListadoEmpleado()
        {
            try
            {
                return _empleadoRepository.List();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_tbEmpleados>();
            }
        }
        #endregion
    }
}
