# Co miał robić minutnik?

## 1. Co robi

1. Program pozwala odmierzać czas pracy i przerwy.
2. Program pozwala ustawić długość pracy i przerwy w minutach.
3. Program pozwala uruchomić, zatrzymać i wznowić odliczanie.
4. Program automatycznie rozpoczyna przerwę po zakończeniu czasu pracy.
5. Program automatycznie rozpoczyna pracę po zakończeniu przerwy.
6. Program pokazuje liczbę ukończonych cykli.
7. Program wyświetla historię ukończonych cykli wraz z czasem ich zakończenia.
8. Program pozwala zresetować minutnik do początku czasu pracy.

## 2. Czego nie robi

- Program nie odtwarza dźwięków po zakończeniu odliczania.
- Program nie wysyła powiadomień o zakończeniu pracy lub przerwy.

## 3. Po czym poznam, że działa

1. Kiedy zmienię czas pracy i nacisnę reset, to minutnik pokaże ustawioną wartość.
2. Kiedy uruchomię minutnik, to czas zacznie się zmniejszać.
3. Kiedy zatrzymam minutnik, to odliczanie zatrzyma się i będzie można je wznowić.
4. Kiedy skończy się czas pracy, to przerwa rozpocznie się automatycznie.
5. Kiedy skończy się przerwa, to rozpocznie się kolejny czas pracy.

## 4. Do ustalenia

- Czy historia ukończonych cykli powinna być zachowywana po zamknięciu aplikacji?

## 5. Porównanie z siedmioma zasadami

Przypomniałam sobie 3 z 7 zasad w całości. Częściowo pamiętałam też zasadę dotyczącą możliwości zmiany czasu pracy i przerwy, ale zapomniałam o domyślnych wartościach 25 i 5 minut.

Nie uwzględniłam w opisie formatu czasu mm:ss, języka interfejsu i nazw w kodzie oraz braku dodatkowych bibliotek.

## 6. Sytuacja, której nie obejmowały zasady

Gdy nacisnę Resetuj podczas przerwy, program zatrzymuje minutnik, wraca do fazy pracy, ustawia początkowy czas pracy i zeruje licznik ukończonych cykli. Historia pozostaje bez zmian.