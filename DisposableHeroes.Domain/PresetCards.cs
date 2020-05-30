﻿using DisposableHeroes.Domain.Cards;
using DisposableHeroes.Domain.Cards.BodyParts;
using System.Collections.Generic;

namespace DisposableHeroes.Domain
{
    public static class PresetCards
    {
        public static List<HeadCard> AllHeadCards()
        {
            List<HeadCard> cards = new List<HeadCard>
            {
                new HeadCard("H-A-01", 0, -1, 1),
                new HeadCard("H-B-01", 1, -1, 2),
                new HeadCard("H-C-01", -1, -1, 4),
                new HeadCard("H-D-01", 1, 0, 2),
                new HeadCard("H-E-01", -2, 1, 2),
                new HeadCard("H-F-01", 0, 0, 1),
                new HeadCard("H-G-01", -1, 0, 2),
                new HeadCard("H-H-01", 0, 0, 1),
                new HeadCard("H-I-01", 0, -3, 4),
                new HeadCard("H-J-01", 0, 0, 1),
                new HeadCard("H-K-01", -3, -2, 4),
                new HeadCard("H-L-01", 0, 0, 2),
                new HeadCard("H-M-01", 1, 0, 1),
                // !!!: H-N-01: Spreadsheet shows PER +54; using PER +1 yor now.
                new HeadCard("H-N-01", 0, -2, 1),
                new HeadCard("H-O-01", 0, -1, 1),
                new HeadCard("H-P-01", 1, 1, 1),
                new HeadCard("H-Q-01", 0, -1, 2),
                new HeadCard("H-R-01", -2, 0, 4),
                new HeadCard("H-S-01", -1, 1, 2),
                new HeadCard("H-T-01", 0, 0, 1),
                new HeadCard("H-U-01", -2, 0, 3),
                new HeadCard("H-A-02", 0, 1, 2),
                new HeadCard("H-B-02", 0, 0, 3),
                new HeadCard("H-C-02", 0, 1, 1),
                new HeadCard("H-D-02", -1, 0, 1),
                new HeadCard("H-E-02", -1, 0, 1),
                new HeadCard("H-F-02", 0, 1, 2),
                new HeadCard("H-G-02", 1, -2, 2),
                new HeadCard("H-H-02", -3, 0, 4),
                new HeadCard("H-I-02", 1, 0, 1),
                new HeadCard("H-J-02", 0, -1, 1),
                new HeadCard("H-K-02", -1, 0, 1),
                new HeadCard("H-L-02", -3, -1, 3),
                new HeadCard("H-M-02", -1, 0, 1),
                new HeadCard("H-N-02", 0, -1, 3),
                new HeadCard("H-O-02", 1, 1, 1),
                new HeadCard("H-P-02", 0, 0, 1),
                new HeadCard("H-Q-02", -1, -1, 2),
                new HeadCard("H-R-02", 0, 0, 2),
                new HeadCard("H-S-02", 0, 0, 1),
                new HeadCard("H-T-02", 0, 0, 1),
                new HeadCard("H-U-02", 0, 0, 2),
                new HeadCard("H-A-03", 0, -1, 2),
                new HeadCard("H-B-03", -1, 0, 2),
                new HeadCard("H-C-03", -1, 0, 3),
                new HeadCard("H-D-03", 0, 0, 1),
                new HeadCard("H-E-03", 1, 0, 2),
                new HeadCard("H-F-03", 0, -1, 1),
                new HeadCard("H-G-03", 0, 0, 3),
                new HeadCard("H-H-03", -2, -1, 3),
                new HeadCard("H-I-03", -1, -1, 2),
                new HeadCard("H-J-03", -1, -3, 3),
                new HeadCard("H-K-03", 0, 1, 1),
                new HeadCard("H-L-03", -1, -3, 3),
                new HeadCard("H-M-03", 0, -2, 3),
                new HeadCard("H-N-03", 1, 0, 1),
                new HeadCard("H-O-03", 1, 0, 3),
                new HeadCard("H-P-03", 0, 0, 1),
                new HeadCard("H-Q-03", 0, 0, 1),
                new HeadCard("H-R-03", 0, 0, 2),
                new HeadCard("H-S-03", 0, 1, 1),
                new HeadCard("H-T-03", 0, 1, 3),
                new HeadCard("H-U-03", 0, 0, 0)
            };

            return cards;
        }

        public static List<ArmsCard> AllArmsCards()
        {
            List<ArmsCard> cards = new List<ArmsCard>
            {
                new ArmsCard("A-A-01", 1, 0, 0),
                new ArmsCard("A-B-01", 3, 0, 0),
                new ArmsCard("A-C-01", 2, 0, 0),
                new ArmsCard("A-D-01", 2, 1, -2),
                new ArmsCard("A-E-01", 2, 1, 0),
                new ArmsCard("A-F-01", 3, 0, 1),
                new ArmsCard("A-G-01", 3, -3, -1),
                new ArmsCard("A-H-01", 2, 0, 1),
                new ArmsCard("A-I-01", 1, -1, 0),
                new ArmsCard("A-J-01", 1, 0, 0),
                new ArmsCard("A-K-01", 1, 0, 0),
                new ArmsCard("A-L-01", 4, -1, -1),
                new ArmsCard("A-M-01", 4, -3, 0),
                new ArmsCard("A-N-01", 1, 0, 0),
                new ArmsCard("A-O-01", 1, 1, 0),
                new ArmsCard("A-P-01", 1, 0, 1),
                new ArmsCard("A-Q-01", 2, 0, 0),
                new ArmsCard("A-R-01", 1, 0, -1),
                new ArmsCard("A-S-01", 2, 0, 0),
                new ArmsCard("A-T-01", 1, -1, 0),
                new ArmsCard("A-U-01", 2, -2, 1),
                new ArmsCard("A-A-02", 1, 0, 0),
                new ArmsCard("A-B-02", 1, -1, 0),
                new ArmsCard("A-C-02", 1, 0, -1),
                new ArmsCard("A-D-02", 2, 1, -1),
                new ArmsCard("A-E-02", 2, -1, 0),
                new ArmsCard("A-F-02", 3, 0, -1),
                new ArmsCard("A-G-02", 2, 0, -1),
                new ArmsCard("A-H-02", 1, 0, 0),
                new ArmsCard("A-I-02", 1, 1, 0),
                new ArmsCard("A-J-02", 1, 0, 0),
                new ArmsCard("A-K-02", 3, -1, -3),
                new ArmsCard("A-L-02", 2, -1, -1),
                new ArmsCard("A-M-02", 2, -1, -1),
                new ArmsCard("A-N-02", 1, 0, -1),
                new ArmsCard("A-O-02", 1, 0, 1),
                new ArmsCard("A-P-02", 3, -1, 0),
                new ArmsCard("A-Q-02", 2, -1, 0),
                new ArmsCard("A-R-02", 1, 1, 1),
                new ArmsCard("A-S-02", 3, 1, 0),
                new ArmsCard("A-T-02", 4, 0, -2),
                new ArmsCard("A-U-02", 2, 1, 0),
                new ArmsCard("A-A-03", 1, 1, 1),
                new ArmsCard("A-B-03", 4, -3, -1),
                new ArmsCard("A-C-03", 1, 1, 0),
                new ArmsCard("A-D-03", 2, 0, -1),
                new ArmsCard("A-E-03", 3, 0, -2),
                new ArmsCard("A-F-03", 1, 0, 0),
                new ArmsCard("A-G-03", 4, -2, -3),
                new ArmsCard("A-H-03", 2, 0, 0),
                new ArmsCard("A-I-03", 3, 0, 0),
                new ArmsCard("A-J-03", 4, -1, -2),
                new ArmsCard("A-K-03", 2, -1, 1),
                new ArmsCard("A-L-03", 3, -2, 0),
                new ArmsCard("A-M-03", 1, 0, -1),
                new ArmsCard("A-N-03", 1, -1, 0),
                new ArmsCard("A-O-03", 1, 0, 0),
                new ArmsCard("A-P-03", 4, -2, 0),
                new ArmsCard("A-Q-03", 1, 0, 0),
                new ArmsCard("A-R-03", 1, 0, 1),
                new ArmsCard("A-S-03", 4, 0, -3),
                new ArmsCard("A-T-03", 2, 0, 1)
            };

            return cards;
        }

        public static List<LegsCard> AllLegsCards()
        {
            List<LegsCard> cards = new List<LegsCard>
            {
                new LegsCard("L-A-01", -1, 1, 0),
                new LegsCard("L-B-01", 0, 1, -1),
                new LegsCard("L-C-01", -3, 4, -1),
                new LegsCard("L-D-01", 0, 3, 0),
                new LegsCard("L-E-01", 0, 2, 0),
                new LegsCard("L-F-01", 0, 1, -1),
                new LegsCard("L-G-01", -1, 3, -3),
                new LegsCard("L-H-01", -1, 2, -1),
                new LegsCard("L-I-01", 0, 4, -3),
                new LegsCard("L-J-01", 0, 1, 0),
                new LegsCard("L-K-01", 1, 1, 1),
                new LegsCard("L-L-01", -2, 3, 0),
                new LegsCard("L-M-01", 0, 1, 0),
                new LegsCard("L-N-01", 0, 1, -1),
                new LegsCard("L-O-01", 1, 3, 0),
                new LegsCard("L-P-01", 1, 2, -2),
                new LegsCard("L-Q-01", 0, 3, -1),
                new LegsCard("L-R-01", -1, 4, -1),
                new LegsCard("L-S-01", -2, 2, 1),
                new LegsCard("L-T-01", 0, 1, 0),
                new LegsCard("L-U-01", -1, 2, 1),
                new LegsCard("L-A-02", 0, 2, 1),
                new LegsCard("L-B-02", 0, 1, 0),
                new LegsCard("L-C-02", -1, 4, -2),
                new LegsCard("L-D-02", -2, 4, 0),
                new LegsCard("L-E-02", 0, 1, 1),
                new LegsCard("L-F-02", 1, 2, 0),
                new LegsCard("L-G-02", 0, 1, 1),
                new LegsCard("L-H-02", 0, 2, 0),
                new LegsCard("L-I-02", 0, 2, 0),
                new LegsCard("L-J-02", 0, 1, -1),
                new LegsCard("L-K-02", -1, 3, 0),
                new LegsCard("L-L-02", 0, 2, 0),
                new LegsCard("L-M-02", 0, 2, -1),
                new LegsCard("L-N-02", 0, 2, 1),
                new LegsCard("L-O-02", 1, 1, 1),
                new LegsCard("L-P-02", -1, 2, 0),
                new LegsCard("L-Q-02", 0, 1, 0),
                new LegsCard("L-R-02", -3, 4, 0),
                new LegsCard("L-S-02", -1, 1, 0),
                new LegsCard("L-T-02", 1, 1, 0),
                new LegsCard("L-U-02", 0, 1, 0),
                new LegsCard("L-A-03", 1, 2, -1),
                new LegsCard("L-B-03", 0, 2, -1),
                new LegsCard("L-C-03", 1, 1, 0),
                new LegsCard("L-D-03", 0, 3, 1),
                new LegsCard("L-E-03", -3, 3, -1),
                new LegsCard("L-F-03", -1, 2, -1),
                new LegsCard("L-G-03", 0, 3, 0),
                new LegsCard("L-H-03", 0, 1, 0),
                new LegsCard("L-I-03", 0, 1, 0),
                new LegsCard("L-J-03", 0, 1, 0),
                new LegsCard("L-K-03", -2, 4, -3),
                new LegsCard("L-L-03", 0, 1, 0),
                new LegsCard("L-M-03", 0, 3, -2),
                new LegsCard("L-N-03", 1, 2, 0),
                new LegsCard("L-O-03", 0, 4, -2),
                new LegsCard("L-P-03", 0, 1, 1),
                new LegsCard("L-Q-03", -1, 1, 0),
                new LegsCard("L-R-03", -1, 1, 0),
                new LegsCard("L-S-03", -1, 2, 0),
                new LegsCard("L-T-03", 1, 1, 0)
            };

            return cards;
        }

        public static List<TorsoCard> AllTorsoCards()
        {
            List<TorsoCard> cards = new List<TorsoCard>
            {
                new TorsoCard("T-A-01", 0, 0, 1, 1),
                new TorsoCard("T-B-01", 0, 1, 0, 1),
                new TorsoCard("T-C-01", 0, 1, 0, 1),
                new TorsoCard("T-D-01", 0, 1, 0, 1),
                new TorsoCard("T-E-01", 0, 1, 0, 1),
                new TorsoCard("T-F-01", 0, 1, 0, 1),
                new TorsoCard("T-G-01", 0, 1, 0, 1),
                new TorsoCard("T-H-01", 0, 0, 1, 1),
                new TorsoCard("T-I-01", 0, 0, 1, 1),
                new TorsoCard("T-J-01", 0, 0, 1, 1),
                new TorsoCard("T-K-01", 0, 0, 1, 1),
                new TorsoCard("T-L-01", 0, 0, 1, 1),
                new TorsoCard("T-M-01", 0, 0, 1, 1),
                new TorsoCard("T-N-01", 1, 0, 0, 1),
                new TorsoCard("T-O-01", 1, 0, 0, 1),
                new TorsoCard("T-P-01", 1, 0, 0, 1),
                new TorsoCard("T-Q-01", 1, 0, 0, 1),
                new TorsoCard("T-R-01", 1, 0, 0, 1),
                new TorsoCard("T-S-01", 1, 0, 0, 1),
                new TorsoCard("T-T-01", 1, 0, 1, 1),
                new TorsoCard("T-U-01", 1, 1, 0, 1),
                new TorsoCard("T-V-01", 0, 1, 1, 1),
                new TorsoCard("T-A-02", 0, 1, 0, 2),
                new TorsoCard("T-B-02", 0, 1, 0, 2),
                new TorsoCard("T-C-02", 0, 2, 0, 2),
                new TorsoCard("T-D-02", 0, 2, 0, 2),
                new TorsoCard("T-E-02", 0, 3, 0, 2),
                new TorsoCard("T-F-02", 0, 0, 1, 2),
                new TorsoCard("T-G-02", 0, 0, 1, 2),
                new TorsoCard("T-H-02", 0, 0, 2, 2),
                new TorsoCard("T-I-02", 0, 0, 2, 2),
                new TorsoCard("T-J-02", 0, 0, 3, 2),
                new TorsoCard("T-K-02", 1, 0, 0, 2),
                new TorsoCard("T-L-02", 1, 0, 0, 2),
                new TorsoCard("T-M-02", 2, 0, 0, 2),
                new TorsoCard("T-N-02", 2, 0, 0, 2),
                new TorsoCard("T-O-02", 3, 0, 0, 2),
                new TorsoCard("T-P-02", 1, 1, 0, 2),
                new TorsoCard("T-Q-02", 1, 1, 0, 2),
                new TorsoCard("T-R-02", 1, 0, 1, 2),
                new TorsoCard("T-S-02", 1, 0, 1, 2),
                new TorsoCard("T-T-02", 0, 1, 1, 2),
                new TorsoCard("T-U-02", 0, 1, 1, 2),
                new TorsoCard("T-A-03", 2, 0, -1, 3),
                new TorsoCard("T-B-03", 0, 0, 2, 3),
                new TorsoCard("T-C-03", 0, 0, 2, 3),
                new TorsoCard("T-D-03", 0, 2, 0, 3),
                new TorsoCard("T-E-03", 0, 2, 0, 3),
                new TorsoCard("T-F-03", 2, 0, 0, 3),
                new TorsoCard("T-G-03", 2, 0, 0, 3),
                new TorsoCard("T-H-03", 2, -1, 0, 3),
                new TorsoCard("T-I-03", -1, 2, 0, 3),
                new TorsoCard("T-J-03", 0, -1, 2, 3),
                new TorsoCard("T-K-03", 0, 2, -1, 3),
                new TorsoCard("T-L-03", -1, 0, 2, 3),
                new TorsoCard("T-M-03", 2, 0, -1, 3),
                new TorsoCard("T-N-03", 1, 1, 1, 3),
                new TorsoCard("T-O-03", 1, 1, 1, 3),
                new TorsoCard("T-P-03", 1, 1, 1, 3),
                new TorsoCard("T-A-04", 0, 2, 0, 4),
                new TorsoCard("T-B-04", 0, 2, 0, 4),
                new TorsoCard("T-C-04", 2, 0, 0, 4),
                new TorsoCard("T-D-04", 2, 0, 0, 4),
                new TorsoCard("T-E-04", 0, 0, 2, 4),
                new TorsoCard("T-F-04", 0, 0, 2, 4),
                new TorsoCard("T-G-04", -1, 2, 0, 4),
                new TorsoCard("T-H-04", -1, 0, 2, 4),
                new TorsoCard("T-I-04", 2, -1, 0, 4),
                new TorsoCard("T-J-04", 2, 0, -1, 4),
                new TorsoCard("T-K-04", 0, -1, 2, 4),
                new TorsoCard("T-L-04", 0, 2, -1, 4),
                new TorsoCard("T-M-04", 1, 1, 1, 4),
                new TorsoCard("T-N-04", 1, 1, 1, 4)
            };

            return cards;
        }

        public static List<WeaponCard> AllWeaponCards()
        {
            List<WeaponCard> cards = new List<WeaponCard>
            {
                new WeaponCard("W-A-01", 2, WeaponType.Normal),
                new WeaponCard("W-B-01", 2, WeaponType.Normal),
                new WeaponCard("W-C-01", 2, WeaponType.Normal),
                new WeaponCard("W-D-01", 2, WeaponType.Normal),
                new WeaponCard("W-E-01", 2, WeaponType.Normal),
                new WeaponCard("W-F-01", 1, WeaponType.Normal),
                new WeaponCard("W-G-01", 1, WeaponType.Normal),
                new WeaponCard("W-H-01", 1, WeaponType.Normal),
                new WeaponCard("W-I-01", 1, WeaponType.Normal),
                new WeaponCard("W-J-01", 1, WeaponType.Normal),
                new WeaponCard("W-K-01", 1, WeaponType.CanEquipOneMorePermanentWeaponOrSpecial),
                new WeaponCard("W-L-01", 2, WeaponType.CanEquipOneMorePermanentWeaponOrSpecial),
                new WeaponCard("W-M-01", 4, WeaponType.Normal),
                new WeaponCard("W-N-01", 1, WeaponType.DealWeaponDamageBackOnEnemyAttack),
                new WeaponCard("W-O-01", 2, WeaponType.BlockAllWeaponDamage),
                new WeaponCard("W-A-02", 2, WeaponType.CanEquipOneMorePermanentWeaponOrSpecial),
                new WeaponCard("W-B-02", 2, WeaponType.IgnoreEnemyDefense),
                new WeaponCard("W-C-02", 1, WeaponType.DealWeaponDamageBackOnEnemyAttack),
                new WeaponCard("W-D-02", 3, WeaponType.DoubleDamageIfEnemyHasNoWeapon),
                new WeaponCard("W-E-02", 2, WeaponType.DoubleDamageIfEnemyHasNoWeapon),
                new WeaponCard("W-F-02", 1, WeaponType.BlockAllWeaponDamage),
                new WeaponCard("W-G-02", 3, WeaponType.Normal),
                new WeaponCard("W-H-02", 4, WeaponType.Normal),
                new WeaponCard("W-I-02", 2, WeaponType.DoubleDamageIfEnemyHasNoWeapon),
                new WeaponCard("W-J-02", 2, WeaponType.BlockAllWeaponDamage),
                new WeaponCard("W-K-02", 4, WeaponType.Normal),
                new WeaponCard("W-L-02", 2, WeaponType.IgnoreEnemyDefense),
                new WeaponCard("W-M-02", 1, WeaponType.IgnoreEnemyDefense),
                new WeaponCard("W-N-02", 3, WeaponType.Normal),
                new WeaponCard("W-O-02", 3, WeaponType.Normal),
                new WeaponCard("W-A-03", 1, WeaponType.CanEquipOneMorePermanentWeaponOrSpecial),
                new WeaponCard("W-B-03", 3, WeaponType.Normal),
                new WeaponCard("W-C-03", 2, WeaponType.DealWeaponDamageBackOnEnemyAttack),
                new WeaponCard("W-D-03", 4, WeaponType.Normal),
                new WeaponCard("W-E-03", 4, WeaponType.Normal),
                new WeaponCard("W-F-03", 3, WeaponType.DoubleDamageIfEnemyHasNoWeapon),
                new WeaponCard("W-G-03", 3, WeaponType.Normal),
                new WeaponCard("W-H-03", 1, WeaponType.BlockAllWeaponDamage),
                new WeaponCard("W-I-03", 1, WeaponType.BlockAllWeaponDamage),
                new WeaponCard("W-J-03", 4, WeaponType.Normal),
                new WeaponCard("W-K-03", 4, WeaponType.Normal),
                new WeaponCard("W-L-03", 3, WeaponType.Normal),
                new WeaponCard("W-M-03", 4, WeaponType.Normal),
                new WeaponCard("W-N-03", 1, WeaponType.IgnoreEnemyDefense)
            };

            return cards;
        }

        public static List<SpecialCard> AllSpecialCards()
        {
            return new List<SpecialCard>() { };
            //return new List<SpecialCard>() {new SpecialCard(SpecialType.OneTimeUse, SpecialEffect.GainHealthOnceByFive)};
        }
    }
}