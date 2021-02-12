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
            CPU CPU1 = new CPU() { CPUName = "Core i3 10100F", CPUSocketType = "LGA 1200", CPUWatts = 65,CPUHeatsink = "Yes", CPUPrice = 110, CPURating = 4 };
            CPU CPU2 = new CPU() { CPUName = "Core i5 10400F", CPUSocketType = "LGA 1200", CPUWatts = 65, CPUHeatsink = "Yes", CPUPrice = 160, CPURating = 6 };
            CPU CPU3 = new CPU() { CPUName = "Core i5 10600k", CPUSocketType = "LGA 1200", CPUWatts = 125, CPUHeatsink = "No", CPUPrice = 230, CPURating = 7 };
            CPU CPU4 = new CPU() { CPUName = "Core i7 10700k", CPUSocketType = "LGA 1200", CPUWatts = 125, CPUHeatsink = "No", CPUPrice = 320, CPURating = 8 };
            CPU CPU5 = new CPU() { CPUName = "Core i9 10900k", CPUSocketType = "LGA 1200", CPUWatts = 125, CPUHeatsink = "No", CPUPrice = 590, CPURating = 9 };
            CPU CPU6 = new CPU() { CPUName = "Ryzen 3 3300x", CPUSocketType = "AM4", CPUWatts = 65, CPUHeatsink = "Yes", CPUPrice = 110, CPURating = 5 };
            CPU CPU7 = new CPU() { CPUName = "Ryzen 5 3600", CPUSocketType = "AM4", CPUWatts = 65, CPUHeatsink = "Yes", CPUPrice = 170, CPURating = 7 };
            CPU CPU8 = new CPU() { CPUName = "Ryzen 5 5600x", CPUSocketType = "AM4", CPUWatts = 65, CPUHeatsink = "Yes", CPUPrice = 270, CPURating = 8 };
            CPU CPU9 = new CPU() { CPUName = "Ryzen 7 5800x", CPUSocketType = "AM4", CPUWatts = 105, CPUHeatsink = "No", CPUPrice = 420, CPURating = 8 };
            CPU CPU10 = new CPU() { CPUName = "Ryzen 9 5900x", CPUSocketType = "AM4", CPUWatts = 105, CPUHeatsink = "No", CPUPrice = 520, CPURating = 10 };

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
            Heatsink Heatsink1 = new Heatsink() { HeatsinkName = "OEM (in box)", HeatsinkSocket = "Any", HeatsinkPrice = 0, HeatsinkRating = 3 };
            Heatsink Heatsink2 = new Heatsink() { HeatsinkName = "Hyper 212", HeatsinkSocket = "Any", HeatsinkPrice = 35, HeatsinkRating = 7 };
            Heatsink Heatsink3 = new Heatsink() { HeatsinkName = "Dark Rock 4", HeatsinkSocket = "Any", HeatsinkPrice = 70, HeatsinkRating = 8 };
            Heatsink Heatsink4 = new Heatsink() { HeatsinkName = "Noctua NH-U12s", HeatsinkSocket = "Any", HeatsinkPrice = 70, HeatsinkRating = 8 };
            Heatsink Heatsink5 = new Heatsink() { HeatsinkName = "MasterLiquid ML120L", HeatsinkSocket = "Any", HeatsinkPrice = 60, HeatsinkRating = 7 };
            Heatsink Heatsink6 = new Heatsink() { HeatsinkName = "Kraken x63", HeatsinkSocket = "Any", HeatsinkPrice = 140, HeatsinkRating = 9 };

            Heatsinks.Add(Heatsink1);
            Heatsinks.Add(Heatsink2);
            Heatsinks.Add(Heatsink3);
            Heatsinks.Add(Heatsink4);
            Heatsinks.Add(Heatsink5);
            Heatsinks.Add(Heatsink6);
            Heatsink_DROP.ItemsSource = Heatsinks;
        }

        private void MOBO_DROP_Loaded(object sender, RoutedEventArgs e)
        {
            MotherBoard MotherBoard1 = new MotherBoard() { MotherboardName = "Gigabyte a320", MotherboardSocket = "AM4", MotherboardSize = "MATX", MotherBoardMaxRam = 16, MotherboardRam = "DDR4", MotherboardPrice = 50, MotherboardRating = 4 };
            MotherBoard MotherBoard2 = new MotherBoard() { MotherboardName = "AsRock b450", MotherboardSocket = "AM4", MotherboardSize = "MATX", MotherBoardMaxRam = 32, MotherboardRam = "DDR4", MotherboardPrice = 75, MotherboardRating = 6 };
            MotherBoard MotherBoard3 = new MotherBoard() { MotherboardName = "MSI b550", MotherboardSocket = "AM4", MotherboardSize = "ATX", MotherBoardMaxRam = 32, MotherboardRam = "DDR4", MotherboardPrice = 120, MotherboardRating = 8 };
            MotherBoard MotherBoard4 = new MotherBoard() { MotherboardName = "Asus x570", MotherboardSocket = "AM4", MotherboardSize = "ATX", MotherBoardMaxRam = 32, MotherboardRam = "DDR4", MotherboardPrice = 200, MotherboardRating = 10 };
            MotherBoard MotherBoard5 = new MotherBoard() { MotherboardName = "Gigabyte h410s", MotherboardSocket = "LGA 1200", MotherboardSize = "MATX", MotherBoardMaxRam = 16, MotherboardRam = "DDR4", MotherboardPrice = 80, MotherboardRating = 4 };
            MotherBoard MotherBoard6 = new MotherBoard() { MotherboardName = "Asus b460-h", MotherboardSocket = "LGA 1200", MotherboardSize = "ATX", MotherBoardMaxRam = 32, MotherboardRam = "DDR4", MotherboardPrice = 150, MotherboardRating = 7 };
            MotherBoard MotherBoard7 = new MotherBoard() { MotherboardName = "MSI z490", MotherboardSocket = "LGA 1200", MotherboardSize = "ATX", MotherBoardMaxRam = 32, MotherboardRam = "DDR4", MotherboardPrice = 240, MotherboardRating = 9 };

            MotherBoards.Add(MotherBoard1);
            MotherBoards.Add(MotherBoard2);
            MotherBoards.Add(MotherBoard3);
            MotherBoards.Add(MotherBoard4);
            MotherBoards.Add(MotherBoard5);
            MotherBoards.Add(MotherBoard6);
            MotherBoards.Add(MotherBoard7);
            MOBO_DROP.ItemsSource = MotherBoards;
        }

        private void Storage1_DROP_Loaded(object sender, RoutedEventArgs e)
        {
            Storage storage1 = new Storage() { StorageSize = "120gb", StorageType = "SSD", StoragePrice = 20, StorageRating = 7 };
            Storage storage2 = new Storage() { StorageSize = "240gb", StorageType = "SSD", StoragePrice = 30, StorageRating = 8 };
            Storage storage3 = new Storage() { StorageSize = "500gb", StorageType = "SSD", StoragePrice = 55, StorageRating = 8 };
            Storage storage4 = new Storage() { StorageSize = "1TB", StorageType = "SSD", StoragePrice = 100, StorageRating = 9 };
            Storage storage5 = new Storage() { StorageSize = "2TB", StorageType = "SSD", StoragePrice = 220, StorageRating = 10 };
            Storage storage6 = new Storage() { StorageSize = "500gb", StorageType = "HDD", StoragePrice = 20, StorageRating = 4 };
            Storage storage7 = new Storage() { StorageSize = "1TB", StorageType = "HDD", StoragePrice = 40, StorageRating = 5 };
            Storage storage8 = new Storage() { StorageSize = "2TB", StorageType = "HDD", StoragePrice = 65, StorageRating = 6 };
            Storage storage9 = new Storage() { StorageSize = "4TB", StorageType = "HDD", StoragePrice = 100, StorageRating = 7 };

            Storages.Add(storage1);
            Storages.Add(storage2);
            Storages.Add(storage3);
            Storages.Add(storage4);
            Storages.Add(storage5);
            Storages.Add(storage6);
            Storages.Add(storage7);
            Storages.Add(storage8);
            Storages.Add(storage9);
            Storage1_DROP.ItemsSource = Storages;
            Storage2_DROP.ItemsSource = Storages;
            Storage3_DROP.ItemsSource = Storages;
        }

        private void CaseRGB_DROP_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void OptionalFans_DROP_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
