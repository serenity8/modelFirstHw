//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransactionsLesson
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int id { get; set; }
        public int idCustomer { get; set; }
        public int idSeller { get; set; }
        public decimal price { get; set; }
        public System.DateTime orderDate { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual Seller Seller { get; set; }
    }
}