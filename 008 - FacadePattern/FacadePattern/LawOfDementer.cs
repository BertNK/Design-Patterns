using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class LawOfDementer
    {
        public LawOfDementer() { }

        public void doSomething() { }
        public void MethodCallOfObject()
        {
            doSomething();
        }

        public void MethodCallOfParameter(LawOfDementer parameterClass) 
        {
            parameterClass.doSomething();
        }

        public void MethodCallOfCreation()
        {
            LawOfDementer creationClass = new LawOfDementer();
            creationClass.doSomething();
        }
        private LawOfDementer uninstantiatedComponent;
        public void MethodCallOfInstantiation()
        {
            uninstantiatedComponent = new LawOfDementer();
            uninstantiatedComponent.doSomething();
        }

        private LawOfDementer ComposedComponent;
        public LawOfDementer(LawOfDementer lawOfDementer)
        {
            ComposedComponent = lawOfDementer;
        }
        public void MethodCallOfComponent()
        {
            ComposedComponent.doSomething();
        }
    }

    internal class Thermometer
    {
        public float GetTemperature()
        {
            return 20.0f;
        }
    }

    internal class WeatherStation
    {
        private readonly Thermometer _thermometer = new Thermometer();

        public Thermometer GetThermometer()
        {
            return _thermometer;
        }
    }

    internal class House
    {
        private readonly WeatherStation _station = new WeatherStation();

        // Yes: House reaches through WeatherStation to call a method on Thermometer.
        public float GetTempWithViolation()
        {
            return _station.GetThermometer().GetTemperature();
        }

        // No: Thermometer is passed to this helper as a parameter.
        public float GetTempWithoutViolation()
        {
            Thermometer thermometer = _station.GetThermometer();
            return GetTempHelper(thermometer);
        }

        private float GetTempHelper(Thermometer thermometer)
        {
            return thermometer.GetTemperature();
        }
    }
}
