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
            CPU CPU1 = new CPU() { CPUName = "Core i3 10100F", CPUSocketType = "LGA 1200", CPUWatts = 65, CPUPrice = 110, CPURating = 4 };
            CPU CPU2 = new CPU() { CPUName = "Core i5 10400F", CPUSocketType = "LGA 1200", CPUWatts = 65, CPUPrice = 160, CPURating = 6 };
            CPU CPU3 = new CPU() { CPUName = "Core i5 10600k", CPUSocketType = "LGA 1200", CPUWatts = 125, CPUPrice = 230, CPURating = 7 };
            CPU CPU4 = new CPU() { CPUName = "Core i7 10700k", CPUSocketType = "LGA 1200", CPUWatts = 125, CPUPrice = 320, CPURating = 8 };
            CPU CPU5 = new CPU() { CPUName = "Core i9 10900k", CPUSocketType = "LGA 1200", CPUWatts = 125, CPUPrice = 590, CPURating = 9 };
            CPU CPU6 = new CPU() { CPUName = "Ryzen 3 3300x", CPUSocketType = "AM4", CPUWatts = 65, CPUPrice = 110, CPURating = 5 };
            CPU CPU7 = new CPU() { CPUName = "Ryzen 5 3600", CPUSocketType = "AM4", CPUWatts = 65, CPUPrice = 170, CPURating = 7 };
            CPU CPU8 = new CPU() { CPUName = "Ryzen 5 5600x", CPUSocketType = "AM4", CPUWatts = 65, CPUPrice = 270, CPURating = 8 };
            CPU CPU9 = new CPU() { CPUName = "Ryzen 7 5800x", CPUSocketType = "AM4", CPUWatts = 105, CPUPrice = 420, CPURating = 8 };
            CPU CPU10 = new CPU() { CPUName = "Ryzen 9 5900x", CPUSocketType = "AM4", CPUWatts = 105, CPUPrice = 520, CPURating = 10 };

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
            GPU GPU1 = new GPU() { GPUName = "GTX 1650", GPUBrand = "EVGA", GPUWatts = 75, GPUPrice = 150, GPURating = 3 };
            GPU GPU2 = new GPU() { GPUName = "RTX 2060", GPUBrand = "Refrence Model", GPUWatts = 160, GPUPrice = 370, GPURating = 5 };
            GPU GPU3 = new GPU() { GPUName = "RTX 3060TI", GPUBrand = "Asus", GPUWatts = 200, GPUPrice = 450, GPURating = 7 };
            GPU GPU4 = new GPU() { GPUName = "RTX 3070", GPUBrand = "MSI", GPUWatts = 220, GPUPrice = 520, GPURating = 8 };
            GPU GPU5 = new GPU() { GPUName = "RTX 3080", GPUBrand = "Gigabyte", GPUWatts = 320, GPUPrice = 700, GPURating = 9 };
            GPU GPU6 = new GPU() { GPUName = "RTX 3090", GPUBrand = "EVGA", GPUWatts = 350, GPUPrice = 1600, GPURating = 10 };
            GPU GPU7 = new GPU() { GPUName = "RX 5500XT", GPUBrand = "Gigabyte", GPUWatts = 120, GPUPrice = 170, GPURating = 4 };
            GPU GPU8 = new GPU() { GPUName = "RX 5700XT", GPUBrand = "PowerColor", GPUWatts = 225, GPUPrice = 400, GPURating = 7 };
            GPU GPU9 = new GPU() { GPUName = "RX 6800", GPUBrand = "XFX", GPUWatts = 250, GPUPrice = 570, GPURating = 8 };
            GPU GPU10 = new GPU() { GPUName = "RX 6800XT", GPUBrand = "Asus", GPUWatts = 300, GPUPrice = 680, GPURating = 9 };
            GPU GPU11 = new GPU() { GPUName = "RX 6900XT", GPUBrand = "PowerColor", GPUWatts = 300, GPUPrice = 1050, GPURating = 9 };

            GPUs.Add(GPU1);
            GPUs.Add(GPU2);
            GPUs.Add(GPU3);
            GPUs.Add(GPU4);
            GPUs.Add(GPU5);
            GPUs.Add(GPU6);
            GPUs.Add(GPU7);
            GPUs.Add(GPU8);
            GPUs.Add(GPU9);
            GPUs.Add(GPU10);
            GPUs.Add(GPU11);
            GPU_DROP.ItemsSource = GPUs;
        }

        private void RAM_DROP_Loaded(object sender, RoutedEventArgs e)
        {
            RAM RAM1 = new RAM() { RAMSpeed = "2666MHZ", RAMType = "DDR4", RAMSize = "8gb", RAMPrice = 30, RAMRating = 6 };
            RAM RAM2 = new RAM() { RAMSpeed = "3000MHZ", RAMType = "DDR4", RAMSize = "8gb", RAMPrice = 35, RAMRating = 7 };
            RAM RAM3 = new RAM() { RAMSpeed = "2666MHZ", RAMType = "DDR4", RAMSize = "16gb", RAMPrice = 60, RAMRating = 8 };
            RAM RAM4 = new RAM() { RAMSpeed = "3200MHZ", RAMType = "DDR4", RAMSize = "16gb", RAMPrice = 75, RAMRating = 9 };
            RAM RAM5 = new RAM() { RAMSpeed = "3000MHZ", RAMType = "DDR4", RAMSize = "32gb", RAMPrice = 140, RAMRating = 10 };
            RAM RAM6 = new RAM() { RAMSpeed = "3600MHZ", RAMType = "DDR4", RAMSize = "32gb", RAMPrice = 155, RAMRating = 10 };

            RAMs.Add(RAM1);
            RAMs.Add(RAM2);
            RAMs.Add(RAM3);
            RAMs.Add(RAM4);
            RAMs.Add(RAM5);
            RAMs.Add(RAM6);
            RAM_DROP.ItemsSource = RAMs;
        }

        private void Heatsink_DROP_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MOBO_DROP_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Storage1_DROP_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void CaseRGB_DROP_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void OptionalFans_DROP_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
