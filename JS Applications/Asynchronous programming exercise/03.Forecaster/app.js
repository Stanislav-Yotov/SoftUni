function attachEvents() {
    let locationsURL = 'http://localhost:3030/jsonstore/forecaster/locations';
    const submitBtn = document.getElementById('submit');
    let locationBar = document.getElementById('location');
    let divForecast = document.getElementById('forecast');
    let currentConditionElement = document.getElementById('current');
    let threeDaysForecastElement = document.getElementById('upcoming');

    function getWeatherSymbol(condition) {
        if (condition === 'Sunny') {
            return '&#x2600';
        } else if (condition === 'Partly sunny') {
            return '&#x26C5';
        } else if (condition === 'Overcast') {
            return '&#x2601';
        } else if (condition === 'Rain') {
            return '&#x2614';
        }
    }

    submitBtn.addEventListener('click', getWeather);

    async function getWeather() {
        try {
            let location = locationBar.value;

            currentConditionElement.innerHTML = '<div class="label">Current conditions</div>';
            threeDaysForecastElement.innerHTML = '<div class="label">Three-day forecast</div>';

            let response = await fetch(locationsURL);
            let locations = await response.json();

            let neededLocation = locations.find(l => l.name === location);

            let currentConditionsResponse = await fetch(`http://localhost:3030/jsonstore/forecaster/today/${neededLocation.code}`);
            let todayForecast = await currentConditionsResponse.json();

            let upcomingResponse = await fetch(`http://localhost:3030/jsonstore/forecaster/upcoming/${neededLocation.code}`);
            let upcomingForecast = await upcomingResponse.json();

            divForecast.style.display = 'inline';

            let weatherSymbol = getWeatherSymbol(todayForecast.forecast.condition);
            let degrees = '&#176';

            let forecastDivElement = document.createElement('div');
            forecastDivElement.className = 'forecasts';

            let conditionSpanElement = document.createElement('span');
            conditionSpanElement.className = 'condition';
            conditionSpanElement.className = 'symbol';
            conditionSpanElement.innerHTML = weatherSymbol;

            forecastDivElement.appendChild(conditionSpanElement);

            let forecastSpanElement = document.createElement('span');
            forecastSpanElement.className = 'condition';

            let locationSpanElement = document.createElement('span');
            locationSpanElement.className = 'forecast-data';
            locationSpanElement.textContent = todayForecast.name;

            let degreesSpanElement = document.createElement('span');
            degreesSpanElement.className = 'forecast-data';
            degreesSpanElement.innerHTML = `${todayForecast.forecast.low}${degrees}/${todayForecast.forecast.high}${degrees}`;

            let weatherSpanElement = document.createElement('span');
            weatherSpanElement.className = 'forecast-data';
            weatherSpanElement.textContent = todayForecast.forecast.condition;

            forecastSpanElement.appendChild(locationSpanElement);
            forecastSpanElement.appendChild(degreesSpanElement);
            forecastSpanElement.appendChild(weatherSpanElement);

            forecastDivElement.appendChild(forecastSpanElement);
            currentConditionElement.appendChild(forecastDivElement);

            let upcomingForecastInfoDiv = document.createElement('div');
            upcomingForecastInfoDiv.className = 'forecast-info';

            upcomingForecast.forecast.forEach((x) => {
                weatherSymbol = getWeatherSymbol(x.condition);

                let upcomingSpan = document.createElement('span');
                upcomingSpan.className = 'upcoming';

                let weatherSymbolSpan = document.createElement('span');
                weatherSymbolSpan.className = 'symbol';
                weatherSymbolSpan.innerHTML = weatherSymbol;

                let degreesSpan = document.createElement('span');
                degreesSpan.className = 'forecast-data';
                degreesSpan.innerHTML = `${x.low}${degrees}/${x.high}${degrees}`;

                let conditonSpan = document.createElement('span');
                conditonSpan.className = 'forecast-data';
                conditonSpan.textContent = x.condition;

                upcomingSpan.appendChild(weatherSymbolSpan);
                upcomingSpan.appendChild(degreesSpan);
                upcomingSpan.appendChild(conditonSpan);

                upcomingForecastInfoDiv.appendChild(upcomingSpan);
            });

            threeDaysForecastElement.appendChild(upcomingForecastInfoDiv);
        } catch (error) {
            divForecast.style.display = "inline";
            let divElements = Array.from(divForecast.children);
            divElements.forEach((x) => (x.style.display = 'none'));

            let p = document.createElement('p');
            p.textContent = 'Error';

            divForecast.appendChild(p);
        }
    }
}

attachEvents();