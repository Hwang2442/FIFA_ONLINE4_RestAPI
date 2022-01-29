﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

namespace FIFA4
{
    #region User information

    [Serializable]
    public class UserInformation
    {
        [JsonProperty("accessId")] public readonly string accessId;
        [JsonProperty("nickname")] public readonly string nickname;

        [JsonProperty("level")] public readonly int level;

        [JsonConstructor]
        public UserInformation([JsonProperty("accessId")] string accessId, [JsonProperty("nickname")] string nickname, [JsonProperty("level")] int level)
        {
            this.accessId = accessId;
            this.nickname = nickname;

            this.level = level;
        }
    }

    [Serializable]
    public class HighestGradeEver
    {
        [JsonProperty("matchType")] public readonly int matchType;
        [JsonProperty("division")] public readonly int division;

        [JsonProperty("achievementDate")] public readonly DateTime achievementDate;

        [JsonConstructor]
        public HighestGradeEver([JsonProperty("matchType")] int matchType, [JsonProperty("division")] int division, [JsonProperty("achievementDate")] string achievementDate)
        {
            this.matchType = matchType;
            this.division = division;

            this.achievementDate = DateTime.Parse(achievementDate);
        }
    }

    [Serializable]
    public class TransactionRecords
    {
        [JsonProperty("tradeDate")] public readonly DateTime tradeDate;

        [JsonProperty("saleSn")] public readonly string saleSn;
        [JsonProperty("spid")] public readonly int spid;

        [JsonProperty("grade")] public readonly int grade;
        [JsonProperty("value")] public readonly ulong money;

        [JsonConstructor]
        public TransactionRecords([JsonProperty("tradeDate")] string tradeDate, [JsonProperty("saleSn")] string saleSn, [JsonProperty("spid")] int spid, [JsonProperty("grade")] int grade, [JsonProperty("value")] ulong money)
        {
            this.tradeDate = DateTime.Parse(tradeDate);

            this.saleSn = saleSn;
            this.spid = spid;

            this.grade = grade;
            this.money = money;
        }
    }


    #endregion

    #region Match information

    [Serializable]
    public class MatchDTO
    {
        [Serializable]
        public class MatchInfoDTO
        {
            [Serializable]
            public class MatchDetailDTO
            {

            }

            public class ShootDTO
            {

            }

            public class PassDTO
            {

            }

            public class DefenceDTO
            {

            }

            [JsonProperty("accessId")] public readonly string accessId;
            [JsonProperty("nickname")] public readonly string nickname;
        }

        [JsonProperty("matchId")] public readonly string matchId;
        [JsonProperty("matchDate")] public readonly DateTime matchDate;
        [JsonProperty("matchType")] public readonly int matchType;
        [JsonProperty("matchInfo")] public readonly MatchInfoDTO[] matchInfos;
    }

    #endregion

    #region Mata information

    [Serializable]
    public class MatchType
    {
        [JsonProperty("matchtype")] public readonly int matchType;
        [JsonProperty("desc")] public readonly string description;

        [JsonConstructor]
        public MatchType([JsonProperty("matchtype")] int matchType, [JsonProperty("desc")] string description)
        {
            this.matchType = matchType;
            this.description = description;
        }
    }

    [Serializable]
    public class Spid
    {
        [JsonProperty("id")] public readonly int id;
        [JsonProperty("name")] public readonly string name;

        [JsonConstructor]
        public Spid([JsonProperty("id")] int id, [JsonProperty("name")] string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    [Serializable]
    public class SeasonId
    {
        [JsonProperty("seasonId")] public readonly int seasonId;
        [JsonProperty("className")] public readonly string className;

        [JsonProperty("seasonImg")] public readonly string seasonImgUrl;

        [JsonConstructor]
        public SeasonId([JsonProperty("seasonId")] int seasonId, [JsonProperty("className")] string className, [JsonProperty("seasonImg")] string seasonImgUrl)
        {
            this.seasonId = seasonId;
            this.className = className;

            this.seasonImgUrl = seasonImgUrl;
        }
    }

    [Serializable]
    public class SpPosition
    {
        [JsonProperty("spposition")] public readonly int spPosition;
        [JsonProperty("desc")] public readonly string desc;

        [JsonConstructor]
        public SpPosition([JsonProperty("spposition")] int spPosition, [JsonProperty("desc")] string desc)
        {
            this.spPosition = spPosition;
            this.desc = desc;
        }
    }

    [Serializable]
    public class Division
    {
        [JsonProperty("divisionId")] public readonly int divisionId;
        [JsonProperty("divisionName")] public readonly string divisionName;

        [JsonConstructor]
        public Division([JsonProperty("divisionId")] int divisionId, [JsonProperty("divisionName")] string divisionName)
        {
            this.divisionId = divisionId;
            this.divisionName = divisionName;
        }
    }

    #endregion
}
