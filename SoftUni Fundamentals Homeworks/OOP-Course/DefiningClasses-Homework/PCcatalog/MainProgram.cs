using System;
using System.Collections.Generic;
using System.Linq;

public class MainProgram
{
    static void Main()
    {
        Computer pc = new Computer();
        pc.Name = "PESHO";
        pc.Price = 4;

        //pc.Processor.Name = "PROCESSOR";
        pc.Processor.Details = "Intel i5 - 5200U";
        //pc.Processor.Price = 123.456;

        //pc.Memory.Name = "RAM";
        pc.Memory.Details = "8 GB";
        //pc.Memory.Price = 23.423;

        //pc.GraphicCard.Name = "Graphic Card";
        pc.GraphicCard.Details = "nVidia GTX 560";
        //pc.GraphicCard.Price = 3235;

        Computer anotherPC = new Computer();
        anotherPC.Name = "GOSHO";
        anotherPC.Price = 3;

        Computer pc2 = new Computer();
        pc2.Name = "ASEN";
        pc2.Price = 5;

        List<Computer> fewComps = new List<Computer>();
        fewComps.Add(pc);
        fewComps.Add(anotherPC);
        fewComps.Add(pc2);

        var orderedComps = fewComps.OrderBy(element => element.TotalPrice);
        
        foreach (var item in orderedComps)
        {
            Console.WriteLine(item.ToString());
        }
    }
}