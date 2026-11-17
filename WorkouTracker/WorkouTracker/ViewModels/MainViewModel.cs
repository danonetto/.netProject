using System.Collections.ObjectModel;
using System.Net.Http.Json;
using WorkouTracker.Models;

namespace WorkouTracker.ViewModels
{
    public class MainViewModel
    {
        private readonly HttpClient _httpClient;

        // Ez a lista fogja tárolni a letöltött gyakorlatokat
        public ObservableCollection<Exercise> Exercises { get; } = new();

        public MainViewModel()
        {
            _httpClient = new HttpClient();
        }

        public async Task LoadExercisesAsync()
        {
            try
            {
                // A Free Exercise DB teljes JSON fájljának letöltése
                var url = "https://raw.githubusercontent.com/yuhonas/free-exercise-db/main/dist/exercises.json";
                var result = await _httpClient.GetFromJsonAsync<List<Exercise>>(url);

                if (result != null)
                {
                    Exercises.Clear();
                    foreach (var exercise in result)
                    {
                        Exercises.Add(exercise);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiba esetén (pl. nincs net) ideiglenesen kiírhatjuk a konzolra
                System.Diagnostics.Debug.WriteLine($"Hiba a letöltéskor: {ex.Message}");
            }
        }
    }
}