using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PcPartHelpenator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /*
     * 
     * ------ GITHUB: https://github.com/B1ADEEE/B1ADEEEs_PC_HELPENATOR
     * 
     */
    public partial class MainWindow : Window
    {
        List<CPU> CPUs = new List<CPU>();
        List<GPU> GPUs = new List<GPU>();
        List<RAM> RAMs = new List<RAM>();
        List<Heatsink> Heatsinks = new List<Heatsink>();
        List<MotherBoard> MotherBoards = new List<MotherBoard>();
        List<Storage> Storages = new List<Storage>();
        List<PowerSupply> PowerSupplies = new List<PowerSupply>();
        List<Case> Cases = new List<Case>();
        List<Optional> Optionals = new List<Optional>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CPU_DROP_Loaded(object sender, RoutedEventArgs e)
        {
            CPU CPU1 = new CPU() { CPUName = "Core i3 10100F", CPUSocketType = "LGA 1200", CPUPrice = 110, CPURating = 4 };
            CPU CPU2 = new CPU() { CPUName = "Core i5 10400F", CPUSocketType = "LGA 1200", CPUPrice = 160, CPURating = 6 };
            CPU CPU3 = new CPU() { CPUName = "Core i5 10600k", CPUSocketType = "LGA 1200", CPUPrice = 230, CPURating = 7 };
            CPU CPU4 = new CPU() { CPUName = "Core i7 10700k", CPUSocketType = "LGA 1200", CPUPrice = 320, CPURating = 8 };
            CPU CPU5 = new CPU() { CPUName = "Core i9 10900k", CPUSocketType = "LGA 1200", CPUPrice = 590, CPURating = 9 };
            CPU CPU6 = new CPU() { CPUName = "Ryzen 3 3300x", CPUSocketType = "AM4", CPUPrice = 110, CPURating = 5 };
            CPU CPU7 = new CPU() { CPUName = "Ryzen 5 3600", CPUSocketType = "AM4", CPUPrice = 170, CPURating = 7 };
            CPU CPU8 = new CPU() { CPUName = "Ryzen 5 5600x", CPUSocketType = "AM4", CPUPrice = 270, CPURating = 8 };
            CPU CPU9 = new CPU() { CPUName = "Ryzen 7 5800x", CPUSocketType = "AM4", CPUPrice = 420, CPURating = 8 };
            CPU CPU10 = new CPU() { CPUName = "Ryzen 9 5900x", CPUSocketType = "AM4", CPUPrice = 520, CPURating = 10 };

            CPUs.Add(CPU1);
            CPUs.Add(CPU2);
            CPUs.Add(CPU3);
            CPUs.Add(CPU4);
            CPUs.Add(CPU5);
            CPUs.Add(CPU6);
            CPUs.Add(CPU7);
            CPUs.Add(CPU8);
            CPUs.Add(CPU9);
            CPUs.Add(CPU10);
            CPU_DROP.ItemsSource = CPUs; 
        }

        private void GPU_DROP_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
