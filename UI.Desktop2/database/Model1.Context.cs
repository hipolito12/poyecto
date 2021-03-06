//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI.Desktop2.database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entidad : DbContext
    {
        public Entidad()
            : base("name=Entidad")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alumnos_inscripciones> alumnos_inscripciones { get; set; }
        public virtual DbSet<comisiones> comisiones { get; set; }
        public virtual DbSet<cursos> cursos { get; set; }
        public virtual DbSet<docentes_cursos> docentes_cursos { get; set; }
        public virtual DbSet<especialidades> especialidades { get; set; }
        public virtual DbSet<materias> materias { get; set; }
        public virtual DbSet<modulos> modulos { get; set; }
        public virtual DbSet<modulos_usuarios> modulos_usuarios { get; set; }
        public virtual DbSet<personas> personas { get; set; }
        public virtual DbSet<planes> planes { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
    
        public virtual int baja(Nullable<int> idMat)
        {
            var idMatParameter = idMat.HasValue ?
                new ObjectParameter("idMat", idMat) :
                new ObjectParameter("idMat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("baja", idMatParameter);
        }
    
        public virtual ObjectResult<consultaplan_Result> consultaplan(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consultaplan_Result>("consultaplan", idParameter);
        }
    
        public virtual ObjectResult<consultarUsuario_Result> consultarUsuario(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consultarUsuario_Result>("consultarUsuario", idParameter);
        }
    
        public virtual int eliminarplan(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("eliminarplan", idParameter);
        }
    
        public virtual int eliminaUsuarios(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("eliminaUsuarios", idParameter);
        }
    
        public virtual int Insertar(string descrip, Nullable<int> semanales, Nullable<int> totales, Nullable<int> idplan)
        {
            var descripParameter = descrip != null ?
                new ObjectParameter("descrip", descrip) :
                new ObjectParameter("descrip", typeof(string));
    
            var semanalesParameter = semanales.HasValue ?
                new ObjectParameter("semanales", semanales) :
                new ObjectParameter("semanales", typeof(int));
    
            var totalesParameter = totales.HasValue ?
                new ObjectParameter("totales", totales) :
                new ObjectParameter("totales", typeof(int));
    
            var idplanParameter = idplan.HasValue ?
                new ObjectParameter("idplan", idplan) :
                new ObjectParameter("idplan", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insertar", descripParameter, semanalesParameter, totalesParameter, idplanParameter);
        }
    
        public virtual int InsertarPlan(string desc, Nullable<int> esp)
        {
            var descParameter = desc != null ?
                new ObjectParameter("desc", desc) :
                new ObjectParameter("desc", typeof(string));
    
            var espParameter = esp.HasValue ?
                new ObjectParameter("esp", esp) :
                new ObjectParameter("esp", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarPlan", descParameter, espParameter);
        }
    
        public virtual int insertarUsuario(Nullable<int> idpersona, string nombreU, string apellido, string nombre, string clave, Nullable<bool> cambia, Nullable<bool> habilitado, string email)
        {
            var idpersonaParameter = idpersona.HasValue ?
                new ObjectParameter("idpersona", idpersona) :
                new ObjectParameter("idpersona", typeof(int));
    
            var nombreUParameter = nombreU != null ?
                new ObjectParameter("nombreU", nombreU) :
                new ObjectParameter("nombreU", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("clave", clave) :
                new ObjectParameter("clave", typeof(string));
    
            var cambiaParameter = cambia.HasValue ?
                new ObjectParameter("cambia", cambia) :
                new ObjectParameter("cambia", typeof(bool));
    
            var habilitadoParameter = habilitado.HasValue ?
                new ObjectParameter("habilitado", habilitado) :
                new ObjectParameter("habilitado", typeof(bool));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertarUsuario", idpersonaParameter, nombreUParameter, apellidoParameter, nombreParameter, claveParameter, cambiaParameter, habilitadoParameter, emailParameter);
        }
    
        public virtual ObjectResult<ListarModulos_Result> ListarModulos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarModulos_Result>("ListarModulos");
        }
    
        public virtual ObjectResult<ListarUsuarios_Result> ListarUsuarios()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarUsuarios_Result>("ListarUsuarios");
        }
    
        public virtual ObjectResult<MostrarMaterias_Result> MostrarMaterias()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MostrarMaterias_Result>("MostrarMaterias");
        }
    
        public virtual ObjectResult<MostrarPlanes_Result> MostrarPlanes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MostrarPlanes_Result>("MostrarPlanes");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int update(string descrip, Nullable<int> plan, Nullable<int> totales, Nullable<int> semanales, Nullable<int> id)
        {
            var descripParameter = descrip != null ?
                new ObjectParameter("descrip", descrip) :
                new ObjectParameter("descrip", typeof(string));
    
            var planParameter = plan.HasValue ?
                new ObjectParameter("plan", plan) :
                new ObjectParameter("plan", typeof(int));
    
            var totalesParameter = totales.HasValue ?
                new ObjectParameter("totales", totales) :
                new ObjectParameter("totales", typeof(int));
    
            var semanalesParameter = semanales.HasValue ?
                new ObjectParameter("semanales", semanales) :
                new ObjectParameter("semanales", typeof(int));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update", descripParameter, planParameter, totalesParameter, semanalesParameter, idParameter);
        }
    
        public virtual ObjectResult<updatemodulo_Result> updatemodulo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<updatemodulo_Result>("updatemodulo");
        }
    
        public virtual int updateplan(string des, Nullable<int> espe, Nullable<int> id)
        {
            var desParameter = des != null ?
                new ObjectParameter("des", des) :
                new ObjectParameter("des", typeof(string));
    
            var espeParameter = espe.HasValue ?
                new ObjectParameter("espe", espe) :
                new ObjectParameter("espe", typeof(int));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateplan", desParameter, espeParameter, idParameter);
        }
    
        public virtual int UpdateUsuario(Nullable<int> id, Nullable<int> idpersona, string nombreU, string apellido, string nombre, string clave, Nullable<bool> cambia, Nullable<bool> habilitado, string email)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var idpersonaParameter = idpersona.HasValue ?
                new ObjectParameter("idpersona", idpersona) :
                new ObjectParameter("idpersona", typeof(int));
    
            var nombreUParameter = nombreU != null ?
                new ObjectParameter("nombreU", nombreU) :
                new ObjectParameter("nombreU", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("clave", clave) :
                new ObjectParameter("clave", typeof(string));
    
            var cambiaParameter = cambia.HasValue ?
                new ObjectParameter("cambia", cambia) :
                new ObjectParameter("cambia", typeof(bool));
    
            var habilitadoParameter = habilitado.HasValue ?
                new ObjectParameter("habilitado", habilitado) :
                new ObjectParameter("habilitado", typeof(bool));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateUsuario", idParameter, idpersonaParameter, nombreUParameter, apellidoParameter, nombreParameter, claveParameter, cambiaParameter, habilitadoParameter, emailParameter);
        }
    }
}
