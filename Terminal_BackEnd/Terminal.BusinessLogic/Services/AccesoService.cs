using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terminal.DataAccess.Repository;
using Terminal.Entities.Entities;

namespace Terminal.BusinessLogic.Services
{
    public class AccesoService
    {
        private readonly UsuariosRepository _usuariosRepository;

        public AccesoService(UsuariosRepository usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;
        }

        #region Usuarios
        public IEnumerable<VW_tbUsuarios> ListadoUsuarios()
        {
            try
            {
                return _usuariosRepository.List();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_tbUsuarios>();
            }
        }

        public ServiceResult InsertarUsuarios(tbUsuarios item)
        {
            var result = new ServiceResult();
            try
            {
                var insert = _usuariosRepository.Insert(item);
                if (insert.MessageStatus == "Registro agregado exitosamente")
                {
                    return result.Ok(insert.MessageStatus);
                }
                else if (insert.MessageStatus == "Ya existe un usuario con ese nombre")
                {
                    return result.Conflict(insert.MessageStatus);
                }
                else
                {
                    return result.BadRequest(insert.MessageStatus);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public VW_tbUsuarios BuscarUsuarios(int id)
        {
            try
            {
                return _usuariosRepository.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RequestStatus BorrarUsuarios(int id)
        {
            try
            {
                return _usuariosRepository.Delete(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RequestStatus UpdateUsuarios(tbUsuarios usuarios)
        {
            try
            {
                return _usuariosRepository.Update(usuarios);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IEnumerable<VW_tbUsuarios> Login(string user, string contrasena)
        {
            try
            {
                return _usuariosRepository.Login(user,contrasena);
               
            }
            catch(Exception error)
            {
                return null;
            }
        }
        #endregion
    }
}
