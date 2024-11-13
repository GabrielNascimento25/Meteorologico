using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteorologico.Models
{
    public class Cidades : ObservableCollection<Cidades>
    {
        private String   siglaUF {  get; set; }
        private String nome {  get; set; }
    }
}
