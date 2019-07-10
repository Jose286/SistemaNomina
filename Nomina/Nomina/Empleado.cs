
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Nomina
{

using System;
    using System.Collections.Generic;
    
public partial class Empleado
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Empleado()
    {

        this.Anticipo = new HashSet<Anticipo>();

        this.Usuario = new HashSet<Usuario>();

        this.Permisos = new HashSet<Permisos>();

        this.Vacaciones = new HashSet<Vacaciones>();

        this.Empleado_Salario_Historico = new HashSet<Empleado_Salario_Historico>();

        this.Liquidacion_Mensual_Detalle = new HashSet<Liquidacion_Mensual_Detalle>();

    }


    public int Id_Empleado { get; set; }

    public string Nombres { get; set; }

    public string Apellidos { get; set; }

    public string Nro_Documento { get; set; }

    public string Direccion { get; set; }

    public string Nro_Telefono { get; set; }

    public System.DateTime Fecha_Nacimiento { get; set; }

    public Nullable<System.DateTime> Fecha_Incorporacion { get; set; }

    public string Imagen_Perfil { get; set; }

    public int Salario_Basico { get; set; }

    public Nullable<int> Turno_Id { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Anticipo> Anticipo { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Usuario> Usuario { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Permisos> Permisos { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Vacaciones> Vacaciones { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Empleado_Salario_Historico> Empleado_Salario_Historico { get; set; }

    public virtual Turno Turno { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Liquidacion_Mensual_Detalle> Liquidacion_Mensual_Detalle { get; set; }

        public override string ToString()
        {
            return this.Nombres + ' '+ this.Apellidos;
        }

    }

}
