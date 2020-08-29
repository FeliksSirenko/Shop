using System;

namespace Shop.Api
{
    /// <summary>
    /// Weather Forecast.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Gets or sets Date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets Temperature Celsius.
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets Temperature Kelvin.
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// Gets or sets Summary.
        /// </summary>
        public string Summary { get; set; }
    }
}
