using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_12
{
    public class VehicleCollections : IEnumerable
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            Vehicle[] vh = new Vehicle[3]
            {
                 new Vehicle("SUzuki",2000),
                 new Vehicle("Hundai",2013),
                 new Vehicle("Tata",1999),
            };
            foreach (Vehicle vOb in vh)
            {
                if (vOb != null)
                {
                    yield return vOb.Make;
                }
                else
                    break;         
            }
        }
    }
}

