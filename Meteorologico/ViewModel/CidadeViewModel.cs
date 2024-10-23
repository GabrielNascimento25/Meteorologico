using CommunityToolkit.Mvvm.ComponentModel;
using Meteorologico.Models;
using Meteorologico.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Meteorologico.ViewModel
{
    public partial class CidadeViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Cidades> cidades;

        private ICommand getCidadesCommand { get; }
        private CidadeService cidadesService { get; }

        public void getCidades()
        {
            getCidades(cidadesService);
        }

        public async void getCidades(CidadeService cidadesService)
        {
            CidadeService CidadeService = new CidadeService();
            cidades = await cidadesService.getCidade();
        }
        public CidadeViewModel()
        {
            cidadesService = new CidadeService();
            getCidadesCommand = new Command(getCidades);
        }
    }

}
