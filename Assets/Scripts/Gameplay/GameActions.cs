using System;

public static class GameActions
{
    public static Action<PlayerData> OnGameStart;
    public static Action OnCardGenerate;
    public static Action OnGameSave;
    public static Action OnCardUse;

    public static Action<Card> OnCardGenerated;
    public static Action OnPlayerStatsChanged;
}
