
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
    
public partial class Liquidacion_Mensual_Detalle
{

    public int Id_Detalle { get; set; }

    public int Liquidacion_Id { get; set; }

    public int Empleado_Id { get; set; }

    public int Concepto_Id { get; set; }

    public int Monto { get; set; }



    public virtual Concepto Concepto { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual Liquidacion_Mensual Liquidacion_Mensual { get; set; }

}

}
