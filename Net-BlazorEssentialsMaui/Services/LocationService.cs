using BlazorEssentials.Models;
using Microsoft.Maui.Devices.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_BlazorEssentialsMaui.Services
{
    public class LocationServiceMaui : ILocationService
    {
        public async Task<GeoLocation> GetLocationAsync()
        {
            try
            {
                Location location = await Geolocation.GetLocationAsync();

                
                return new GeoLocation() { Lat = location.Latitude, Lon = location.Longitude };
            }
            catch (Exception ex)
            {
                try
                {
                    Location loc = await Geolocation.GetLastKnownLocationAsync();
                    return new GeoLocation() { Lat = loc.Latitude, Lon = loc.Longitude };
                }
                catch (Exception exc)
                {
                    return null;
                }
            }
        }
    }
}
