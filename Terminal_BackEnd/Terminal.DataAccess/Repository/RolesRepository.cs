using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Terminal.Entities.Entities;

namespace Terminal.DataAccess.Repository
{
    public class RolesRepository : IRepository<tbRoles, VW_Roles_VW>
    {
        public VW_Roles_VW Find(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@role_ID", id, DbType.Int32, ParameterDirection.Input);

            return db.QueryFirst<VW_Roles_VW>(ScriptsDataBase.UDP_tbRoles_Find, parametros, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<VW_Roles_VW> List()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            return db.Query<VW_Roles_VW>(ScriptsDataBase.UDP_tbRoles_Select, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Insert(string item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@role_UsuarioCreador", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@role_Descripcion", item, DbType.String, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_tbRoles_Insert, parametros, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Update(tbRoles item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@role_UsuarioModificador    ", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@role_ID", item.role_ID, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@role_Descripcion", item.role_Descripcion, DbType.String, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_tbRoles_Update, parametros, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Delete(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
             parametros.Add("@role_ID", id, DbType.Int32, ParameterDirection.Input);
             return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_tbRoles_Delete, parametros, commandType: CommandType.StoredProcedure);

        }


        //////////////////////////////////////////////////////////////////////


        public VW_RolXPantalla_VW FindXpantalla(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@role_ID", id, DbType.Int32, ParameterDirection.Input);

            return db.QueryFirst<VW_RolXPantalla_VW>(ScriptsDataBase.UDP_tbRolesXPantallas_Find, parametros, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<VW_RolXPantalla_VW> ListXpantalla()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            return db.Query<VW_RolXPantalla_VW>(ScriptsDataBase.UDP_tbRolesXPantallas_Select, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus InsertXpantalla(tbRolesXPantallas item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@roleXpant_UsuarioCreador", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@role_ID", item.role_ID, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pant_ID", item.pant_ID, DbType.Int32, ParameterDirection.Input);

            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_tbRolesXPantallas_Insert, parametros, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus UpdateXpantalla(tbRolesXPantallas item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@@roleXpant_UsuarioModificador", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@role_ID", item.role_ID, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@pant_ID", item.pant_ID, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_tbRoles_Update, parametros, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus DeleteXpantalla(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@role_ID", id, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_tbRoles_Delete, parametros, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Insert(tbRoles item)
        {
            throw new NotImplementedException();
        }
    }
}
