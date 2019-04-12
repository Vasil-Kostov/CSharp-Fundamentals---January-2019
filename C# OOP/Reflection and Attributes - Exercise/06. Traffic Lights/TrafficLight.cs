namespace _06._Traffic_Lights
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TrafficLight
    {
        private List<Light> lights;

        public TrafficLight(string[] lightsArr)
        {
            this.lights = new List<Light>();
            this.FillTraficLights(lightsArr);
        }

        private void FillTraficLights(string[] lightsArr)
        {
            for (int i = 0; i < lightsArr.Length; i++)
            {
                this.lights.Add(Enum.Parse<Light>(lightsArr[i]));
            }
        }

        private void ChangeSignal()
        {
            for (int i = 0; i < this.lights.Count; i++)
            {
                this.lights[i] = (Light)(((int)lights[i] + 1) % Enum.GetNames(typeof(Light)).Length);
            }
        }

        public override string ToString()
        {
            return string.Join(" ", this.lights);
        }
    }
}
