//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContabilWindowsFormsApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lancamentos
    {
        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public int IdConta { get; set; }
        public System.DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public string Historico { get; set; }
        public int IdContaDebito { get; set; }
        public int IdContaCredito { get; set; }
    
        public virtual Contas Contas { get; set; }
        public virtual Empresas Empresas { get; set; }
        public virtual Contas Contas1 { get; set; }
        public virtual Contas Contas11 { get; set; }
    }
}