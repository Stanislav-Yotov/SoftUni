using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;

            Drones = new List<Drone>();
        }

        public List<Drone> Drones { get; private set; }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }
        public int Count => Drones.Count;

        public string AddDrone(Drone drone)
        {
            if (Drones.Count > Capacity)
            {
                return "Airfield is full.";
            }
            if (string.IsNullOrEmpty(drone.Name))
            {
                return "Invalid drone.";
            }
            if (string.IsNullOrEmpty(drone.Brand))
            {
                return "Invalid drone.";
            }
            if (drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }

            Drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            Drone drone = Drones.FirstOrDefault(d => d.Name == name);
            if (drone == null)
            {
                return false;
            }
            Drones.Remove(drone);
            return true;
        }

        public int RemoveDroneByBrand(string brand)
        {
            Drone drone = Drones.Find(d => d.Brand == brand);
            if (drone == null)
            {
                return 0;
            }
            return Drones.RemoveAll(d => d.Brand == brand);
        }

        public Drone FlyDrone(string name)
        {
            Drone drone = Drones.Find(d => d.Name == name);
          
            if (drone == null)
            {
                return null;
            }
            drone.Available = false;
            return drone;
            

        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> drones = Drones.FindAll(d => d.Range >= range);
            foreach (var drone in drones)
            {
                drone.Available = false;
            }
            return drones;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drones available at {Name}");
            foreach (var drone in Drones.Where(d => d.Available == true))
            {
                sb.AppendLine(drone.ToString());

            }

            return sb.ToString().Trim();
        }
    }
}
