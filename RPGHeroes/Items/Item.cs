﻿namespace RPGHeroes.Items
{
    public enum Slot
    {
        Weapon,
        Head,
        Body,
        Legs
    }
    public abstract class Item
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public Slot Slot { get; set; }
    }
}
