//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoeduSam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Man { get; set; }
        public int Active { get; set; }
        public int Price { get; set; }
        public string ActiveStr { get {
                if (Active == 1) return "да";
                else return "нет";
        } }
    }
}
