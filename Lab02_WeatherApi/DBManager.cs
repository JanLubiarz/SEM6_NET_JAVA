using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_WeatherApi
{
    internal class DBManager
    {
        private Kontekst kontekst;
        private HttpClient klient;

        public DBManager()
        {
            kontekst = new Kontekst();
            klient = new HttpClient();
        }

        public async Task Dodaj(double latitude, double longitude)
        {
            string call = $"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid=cabfbbd83e9d1d15d1bb3e273c42662d";
            string response = await klient.GetStringAsync(call);
            Root baza = JsonSerializer.Deserialize<Root>(response);

            String city = baza.name;
            double tempC = baza.main.temp - 273.15;
            double tempOdczuwalnaC = baza.main.feels_like - 273.15;
            int cisnienie = baza.main.pressure;
            int wilgotnosc = baza.main.humidity;
            double predkoscWiatru = baza.wind.speed;

            if (kontekst.Weathers.Any(w => w.city_name == city))
            {
                // Jeśli dane już istnieją, pomiń dodawanie nowych danych
                Console.WriteLine($"Dane dla lokalizacji {city} już istnieją w bazie.");
                return;
            }

            Struktura struktura = new Struktura(city, tempC, tempOdczuwalnaC, cisnienie, wilgotnosc, predkoscWiatru);
            
            kontekst.Weathers.Add(struktura);
            kontekst.SaveChanges();
        }

        public void usun()
        {
            kontekst.Weathers.RemoveRange(kontekst.Weathers);        
            kontekst.SaveChanges();
        }

        public List<Struktura> Lista()
        {
            return kontekst.Weathers.ToList();
        }
    }
}
