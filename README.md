# Minutnik Pomodoro

## Opis projektu

Minutnik Pomodoro to aplikacja desktopowa napisana w C# z użyciem Avalonia UI. Służy do odmierzania czasu pracy i przerw oraz liczenia ukończonych cykli.

## Funkcje aplikacji

- Domyślny czas pracy: 25 minut.
- Domyślny czas przerwy: 5 minut.
- Możliwość zmiany czasu pracy i przerwy.
- Jeden przycisk uruchamiania i wstrzymywania minutnika.
- Przycisk resetowania.
- Automatyczne rozpoczęcie przerwy po zakończeniu pracy.
- Licznik ukończonych cykli.
- Historia ukończonych cykli wraz z godziną.
- Wyświetlanie czasu w formacie `mm:ss`.
- Interfejs w języku polskim i angielskie nazwy w kodzie.

## Uruchamianie aplikacji

1. Otwórz folder projektu `minutnik` w Visual Studio Code.
2. Otwórz terminal w folderze projektu.
3. Wpisz polecenie:

   `dotnet run`

## Pomiar tokenów pierwszej wiadomości do agenta

Data pomiaru: 25.10.2026

Narzędzie: [Tokenizer Playground](https://huggingface.co/spaces/Xenova/the-tokenizer-playground).

Pierwsza wiadomość wysłana do agenta zawierała polecenie zbudowania minutnika w projekcie Avalonia.

- Liczba tokenów wiadomości po polsku: 170.
- Liczba tokenów wiadomości po angielsku: 104.

## Model AI i jego limity

Narzędzie: GitHub Copilot w Visual Studio Code.

Model wyświetlany w czacie: GPT-6 Luna.

Data sprawdzenia: 25.10.2026.

- Okno kontekstu: 1 050 000 tokenów.
- Maksymalna długość odpowiedzi: 128 000 tokenów.

Źródła:
- [OpenAI: dokumentacja modeli](https://developers.openai.com/api/docs/models)
- [GitHub: obsługiwane modele GitHub Copilot](https://docs.github.com/en/copilot/reference/ai-models/supported-models)

Podane limity dotyczą modelu GPT-6 Luna. Limity dostępne w GitHub Copilot mogą zależeć od konfiguracji narzędzia.

## Test wprowadzania czasu

Data testu: 25.10.2026.

Test wykonano w polu ustawiania czasu pracy.

- Wartość `25,5`: pole zmieniło wartość na `26`, ale minutnik odliczał 25 minut.
- Wartość `25.5`: minutnik odliczał 25 minut.

Aplikacja jest przeznaczona do ustawiania czasu w pełnych minutach.

## Technologie

- C#
- Avalonia UI
- .NET
- DispatcherTimer

Aplikacja nie wymaga dodatkowych bibliotek.