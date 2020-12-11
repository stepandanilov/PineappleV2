using PineappleV2.Models;
using PineappleV2.Models.ComputerSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineappleV2.Util
{
    public class TestData
    {   
        public void ClearData()
        {
            using (var context = new PineappleContext())
            {
                //context.CompSettings.RemoveRange(context.CompSettings);
                context.Computers.RemoveRange(context.Computers);
                context.Departments.RemoveRange(context.Departments);
                context.Employees.RemoveRange(context.Employees);
                context.Peripheries.RemoveRange(context.Peripheries);
                //context.PerSettings.RemoveRange(context.PerSettings);
                context.Positions.RemoveRange(context.Positions);
                //periphery
                context.Cpus.RemoveRange(context.Cpus);
                context.Hdds.RemoveRange(context.Hdds);
                context.Monitors.RemoveRange(context.Monitors);
                context.Motherboards.RemoveRange(context.Motherboards);
                context.Mouses.RemoveRange(context.Mouses);
                context.Printers.RemoveRange(context.Printers);

                context.SaveChanges();
            }
        }
        public void FillDb()
        {
            using (var context = new PineappleContext())
            {
                //positions
                var position1 = new Position()
                {
                    Name = "Директор"
                };
                var position2 = new Position()
                {
                    Name = "Бухгалтер"
                };
                var position3 = new Position()
                {
                    Name = "Системный администратор"
                };
                var position4 = new Position()
                {
                    Name = "Программист"
                };
                var position5 = new Position()
                {
                    Name = "Заместитель"
                };
                context.Positions.Add(position1);
                context.Positions.Add(position2);
                context.Positions.Add(position3);
                context.Positions.Add(position4);
                context.Positions.Add(position5);
                //departments
                var department1 = new Department()
                {
                    Id = 1,
                    Name = "Технический"
                };
                var department2 = new Department()
                {
                    Id = 2,
                    Name = "Юридический"
                };
                var department3 = new Department()
                {
                    Id = 3,
                    Name = "Бухгалтерский"
                };
                var department4 = new Department()
                {
                    Id = 4,
                    Name = "ИТ"
                };
                context.Departments.Add(department1);
                context.Departments.Add(department2);
                context.Departments.Add(department3);
                context.Departments.Add(department4);
                context.SaveChanges();
                //main
                
                var periphery1 = new Periphery()
                {
                    Id = 1,
                    Condition = "Работает"
                };
                var periphery2 = new Periphery()
                {
                    Id = 2,
                    Condition = "На ремонте"
                };
                var periphery3 = new Periphery()
                {
                    Id = 3,
                    Condition = "Сломан"
                };
                context.Peripheries.Add(periphery1);
                context.Peripheries.Add(periphery2);
                context.Peripheries.Add(periphery3);
                
                //periphery
                var cpu1 = new CPU()
                {
                    Id = 1,
                    name = "R5-3600",
                    frequency = "3600MHz",
                    manufacturer = "AMD"
                };
                var cpu2 = new CPU()
                {
                    Id = 2,
                    name = "i5-9400F",
                    frequency = "2.9GHz",
                    manufacturer = "Intel"
                };
                var cpu3 = new CPU()
                {
                    Id = 3,
                    name = "i7-960",
                    frequency = "3200Mhz",
                    manufacturer = "Intel"
                };
                var cpu4 = new CPU()
                {
                    Id = 4,
                    name = "i5-10400",
                    frequency = "2.9GHz",
                    manufacturer = "Intel"
                };
                var cpu5 = new CPU()
                {
                    Id = 5,
                    name = "R5-3500x",
                    frequency = "3.6GHz",
                    manufacturer = "AMD"
                };
                context.Cpus.Add(cpu1);
                context.Cpus.Add(cpu2);
                context.Cpus.Add(cpu3);
                context.Cpus.Add(cpu4);
                context.Cpus.Add(cpu5);

                var hdd1 = new HDD()
                {
                    name= "WD10EZEX",
                    manufacturer = "SATA",
                    space = "1TB"
                };
                var hdd2 = new HDD()
                {
                    name = "ST2000DM008",
                    manufacturer = "Seagate Barracuda",
                    space = "2TB"
                };
                var hdd3 = new HDD()
                {
                    name = "KOKOKOKOKWEDWQDS",
                    manufacturer = "Toshiba",
                    space = "1TB"
                };
                var hdd4 = new HDD()
                {
                    name = "HDWD105UZASDA",
                    manufacturer = "Toshiba",
                    space = "500GB"
                };
                var hdd5 = new HDD()
                {
                    name = "ASDASDASDASD",
                    manufacturer = "Toshiba",
                    space = "1TB"
                };
                context.Hdds.Add(hdd1);
                context.Hdds.Add(hdd2);
                context.Hdds.Add(hdd3);
                context.Hdds.Add(hdd4);
                context.Hdds.Add(hdd5);
                context.SaveChanges();

                var motherboard1 = new Motherboard()
                {
                    name = "A320M-DVS R4.0",
                    manufacturer = "ASRock"
                };
                var motherboard2 = new Motherboard()
                {
                    name = "A68HM-K",
                    manufacturer = "ASUS"
                };
                var motherboard3 = new Motherboard()
                {
                    name = "H310CM-HDV",
                    manufacturer = "ASRock"
                };
                var motherboard4 = new Motherboard()
                {
                    name = "760GM-HDV",
                    manufacturer = "ASRock"
                };
                var motherboard5 = new Motherboard()
                {
                    name = "A320M-PRO-E",
                    manufacturer = "MSI"
                };
                context.Motherboards.Add(motherboard1);
                context.Motherboards.Add(motherboard2);
                context.Motherboards.Add(motherboard3);
                context.Motherboards.Add(motherboard4);
                context.Motherboards.Add(motherboard5);
                context.SaveChanges();
                var monitor1 = new Monitor()
                {
                    name = "T3U81AA",
                    manufacturer = "HP"
                };
                var monitor2 = new Monitor()
                {
                    name = "193V5LSB2",
                    manufacturer = "Philips"
                };
                var monitor3 = new Monitor()
                {
                    name = "E970SWN",
                    manufacturer = "AOC"
                };
                var monitor4 = new Monitor()
                {
                    name = "V206HQLAb",
                    manufacturer = "Acer"
                };
                var monitor5 = new Monitor()
                {
                    name = "T3U83AA",
                    manufacturer = "HP"
                };

                context.Monitors.Add(monitor1);
                context.Monitors.Add(monitor2);
                context.Monitors.Add(monitor3);
                context.Monitors.Add(monitor4);
                context.Monitors.Add(monitor5);

                var mouse1 = new Mouse()
                {
                    name = "G102",
                    manufacturer = "Logitech"
                };
                var mouse2 = new Mouse()
                {
                    name = "M170",
                    manufacturer = "Logitech"
                };
                var mouse3 = new Mouse()
                {
                    name = "G502-Hero",
                    manufacturer = "Logitech"
                };
                var mouse4 = new Mouse()
                {
                    name = "DeathAdder",
                    manufacturer = "Razer"
                };
                var mouse5 = new Mouse()
                {
                    name = "G403-Hero",
                    manufacturer = "Logitech"
                };
                context.Mouses.Add(mouse1);
                context.Mouses.Add(mouse2);
                context.Mouses.Add(mouse3);
                context.Mouses.Add(mouse4);
                context.Mouses.Add(mouse5);

                var printer1 = new Printer()
                {
                    name = "Phaser 3020",
                    manufacturer = "Xerox"
                };
                var printer2 = new Printer()
                {
                    name = "HL-L2300DR",
                    manufacturer = "Brother"
                };
                var printer3 = new Printer()
                {
                    name = "L805",
                    manufacturer = "Epson"
                };
                var printer4 = new Printer()
                {
                    name = "L120",
                    manufacturer = "Epson"
                };
                var printer5 = new Printer()
                {
                    name = "L1110",
                    manufacturer = "Epson"
                };
                context.Printers.Add(printer1);
                context.Printers.Add(printer2);
                context.Printers.Add(printer3);
                context.Printers.Add(printer4);
                context.Printers.Add(printer5);
                context.SaveChanges();
                var computer1 = new Computer()
                {
                    Id = 1,
                    Condition = "Работает",
                    cpu = cpu1,
                    hdd = hdd1,
                    monitor = monitor1,
                    motherboard = motherboard1,
                    mouse = mouse1,
                    printer = printer1
            };
                
                var computer2 = new Computer()
                {
                    Id = 2,
                    Condition = "На ремонте",
                    cpu = cpu2,
                    hdd = hdd2,
                    monitor = monitor2,
                    motherboard = motherboard2,
                    mouse = mouse2,
                    printer = printer2
                };
                var computer3 = new Computer()
                {
                    Condition = "Сломан",
                    cpu = cpu3,
                    hdd = hdd3,
                    monitor = monitor3,
                    motherboard = motherboard3,
                    mouse = mouse3,
                    printer = printer3
                };
                var computer4 = new Computer()
                {
                    Condition = "Сломан",
                    cpu = cpu4,
                    hdd = hdd4,
                    monitor = monitor4,
                    motherboard = motherboard4,
                    mouse = mouse4,
                    printer = printer4
                };
                var computer5 = new Computer()
                {
                    Condition = "Сломан",
                    cpu = cpu5,
                    hdd = hdd5,
                    monitor = monitor5,
                    motherboard = motherboard5,
                    mouse = mouse5,
                    printer = printer5
                };
                context.Computers.Add(computer1);
                context.Computers.Add(computer2);
                context.Computers.Add(computer3);
                context.Computers.Add(computer4);
                context.Computers.Add(computer5);
                var employee1 = new Employee()
                {
                    Id = 1,
                    Name = "Иван",
                    Surname = "Иванов",
                    DateOfBirth = DateTime.Now.AddYears(-35),
                    Position = position1.Name,
                    Department = department1.Name
                };
                var employee2 = new Employee()
                {
                    Id = 2,
                    Name = "Степанов",
                    Surname = "Степан",
                    DateOfBirth = DateTime.Now.AddYears(-34),
                    Position = position2.Name,
                    Department = department2.Name
                };
                var employee3 = new Employee()
                {
                    Id = 3,
                    Name = "Петров",
                    Surname = "Петр",
                    DateOfBirth = DateTime.Now.AddYears(-29),
                    Position = position3.Name,
                    Department = department3.Name
                };
                var employee4 = new Employee()
                {
                    Id = 3,
                    Name = "Кычкин",
                    Surname = "Кычик",
                    DateOfBirth = DateTime.Now.AddYears(-30),
                    Position = position4.Name,
                    Department = department4.Name
                };
                context.Employees.Add(employee1);
                context.Employees.Add(employee2);
                context.Employees.Add(employee3);
                context.Employees.Add(employee4);
                context.SaveChanges();
            }
        }
    }
}
