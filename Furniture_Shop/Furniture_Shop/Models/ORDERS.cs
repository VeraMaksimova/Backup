//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Furniture_Shop.Models
{

    public partial class ORDERS : INotifyPropertyChanged
    {
        private int order_id1;
        private string name_of_ordered_product1;
        private Nullable<decimal> price_of_ordered_product1;
        private string ordered_person1;
        private string status1;
        public int order_id
        {
            get => order_id1; set
            {
                order_id1 = value;
                OnPropertyChanged(nameof(order_id));
            }
        }
        public string name_of_ordered_product
        {
            get => name_of_ordered_product1; set
            {
                name_of_ordered_product1 = value;
                OnPropertyChanged(nameof(name_of_ordered_product));
            }
        }

        public Nullable<decimal> price_of_ordered_product
        {
            get => price_of_ordered_product1; set
            {
                price_of_ordered_product1 = value;
                OnPropertyChanged(nameof(price_of_ordered_product));
            }
        }
        public string ordered_person
        {
            get => ordered_person1; set
            {
                ordered_person1 = value;
                OnPropertyChanged(nameof(ordered_person));
            }
        }
        public string status
        {
            get => status1; set
            {
                status1 = value;
                OnPropertyChanged(nameof(status));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
