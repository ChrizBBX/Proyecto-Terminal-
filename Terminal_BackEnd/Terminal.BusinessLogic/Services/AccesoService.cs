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

        public ServiceResult BorrarUsuarios(int id)
        {
            var result = new ServiceResult();
            try
            {
                var delete = _usuariosRepository.Delete(id);
                if (delete.MessageStatus == "Registro eliminado con exito")
                {
                    return result.Ok(delete.MessageStatus);
                }
                else
                {
                    return result.BadRequest(delete.MessageStatus);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public ServiceResult UpdateUsuarios(tbUsuarios usuarios)
        {
            var result = new ServiceResult();
            try
            {
                var edit = _usuariosRepository.Update(usuarios);
                if (edit.MessageStatus == "Registro editado exitosamente")
                {
                    return result.Ok(edit.MessageStatus);
                }
                else if(edit.MessageStatus == "Registro ya existente")
                {
                    return result.Conflict(edit.MessageStatus);
                }
                else
                {
                    return result.BadRequest(edit.MessageStatus);
                }
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

        public IEnumerable<tbPantallas> Roles(int role_ID, bool esAdmin)
        {
            try
            {
                return _usuariosRepository.Roles(role_ID,esAdmin);

            }
            catch (Exception error)
            {
                return null;
            }
        }
        #endregion
    }
}
