using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Terminal.Entities.Entities;

namespace Terminal.DataAccess.Repository
{
    public class UsuariosRepository : IRepository<tbUsuarios, VW_tbUsuarios>
    {
        public VW_tbUsuarios Find(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@usua_ID", id, DbType.Int32, ParameterDirection.Input);

            return db.QueryFirst<VW_tbUsuarios>(ScriptsDataBase.UDP_Usuarios_Find, parametros, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<VW_tbUsuarios> List()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<VW_tbUsuarios>(ScriptsDataBase.UDP_Usuarios_Select, null, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Insert(tbUsuarios item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@usua_UsuarioCreador", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_Usuario", item.usua_Usuario, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_Clave", item.usua_Clave, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_EsAdmin", item.usua_EsAdmin, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_ID", item.empl_ID, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Usuarios_Create, parametros, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Update(tbUsuarios item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@usua_UsuarioCreador", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_ID", item.usua_ID, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usua_Usuario", item.usua_Usuario, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_Clave", item.usua_Clave, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_EsAdmin", item.usua_EsAdmin, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_ID", item.empl_ID, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Usuarios_Update, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Delete(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@usua_ID", id, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Usuarios_Delete, parametros, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<VW_tbUsuarios> Login(string user,string contrasena)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@usua_Usuario",user, DbType.String, ParameterDirection.Input);
            parametros.Add("@usua_Clave", contrasena, DbType.String, ParameterDirection.Input);
            return db.Query<VW_tbUsuarios>(ScriptsDataBase.UDP_Login, parametros, commandType: CommandType.StoredProcedure);
        }
    }
}
