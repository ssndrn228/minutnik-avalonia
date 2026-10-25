using Avalonia.Controls;
using Avalonia.Threading;
using System;
using System.Collections.Generic;

namespace minutnik;

public partial class MainWindow : Window
{
    private readonly List<string> _history = new();
    private readonly DispatcherTimer timer;
    private int remainingSeconds;
    private int completedCycles;
    private bool isBreakPhase;

    public MainWindow()
    {
        InitializeComponent();

        timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
        timer.Tick += OnTimerTick;

        WorkDurationInput.ValueChanged += OnDurationChanged;
        BreakDurationInput.ValueChanged += OnDurationChanged;

        ResetTimer();
    }

    private void OnDurationChanged(object? sender, NumericUpDownValueChangedEventArgs e)
    {
        if (!timer.IsEnabled && !isBreakPhase)
        {
            remainingSeconds = GetDurationSeconds(WorkDurationInput);
            UpdateDisplay();
        }
    }

    private void OnStartPauseClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (timer.IsEnabled)
        {
            timer.Stop();
            StartPauseButton.Content = "Wznów";
            return;
        }

        timer.Start();
        StartPauseButton.Content = "Pauza";
    }

    private void OnResetClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ResetTimer();
    }

    private void OnTimerTick(object? sender, EventArgs e)
    {
        remainingSeconds--;

        if (remainingSeconds <= 0)
        {
            if (isBreakPhase)
            {
                completedCycles++;
                _history.Add($"{DateTime.Now:HH:mm} - cykl {completedCycles}");
                HistoryList.ItemsSource = _history.ToArray();

                isBreakPhase = false;
                remainingSeconds = GetDurationSeconds(WorkDurationInput);
            }
            else
            {
                isBreakPhase = true;
                remainingSeconds = GetDurationSeconds(BreakDurationInput);
            }
        }

        UpdateDisplay();
    }

    private void ResetTimer()
    {
        timer.Stop();
        isBreakPhase = false;
        remainingSeconds = GetDurationSeconds(WorkDurationInput);
        completedCycles = 0;
        StartPauseButton.Content = "Uruchom";
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        TimeText.Text = $"{remainingSeconds / 60:00}:{remainingSeconds % 60:00}";
        PhaseText.Text = isBreakPhase ? "PRZERWA" : "PRACA";
        PhaseDetailText.Text = isBreakPhase ? "Chwila oddechu" : "Pełne skupienie";
        CycleText.Text = completedCycles.ToString();
    }

    private static int GetDurationSeconds(NumericUpDown input)
    {
        return (int)(input.Value ?? 1) * 60;
    }
}