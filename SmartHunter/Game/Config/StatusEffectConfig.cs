namespace SmartHunter.Game.Config
{
    public partial class StatusEffectConfig
    {
        public string GroupId;
        public string NameStringId;
        public string TimerOffset;
        public MemorySource Source;
        public MemoryConditionConfig[] Conditions;

        public StatusEffectConfig(string groupId, string nameStringId, MemorySource source, string timerOffset, params MemoryConditionConfig[] conditions)
        {
            GroupId = groupId;
            NameStringId = nameStringId;
            Source = source;
            TimerOffset = timerOffset;
            Conditions = conditions;
        }
    }
}
