﻿namespace Mcpgnz.DesktopFramework
{
    using Mcpgnz.Utilities;
    using Sirenix.OdinInspector;
    using UnityEngine;

    [CreateAssetMenu(menuName = "Framework/Config")]
    public sealed class Config : ScriptableObjectSingleton<Config>
    {
        #region Public Variables
        public static int MovementSpeed => Instance._MovementSpeed;
        #endregion Public Variables

        #region Private Variables
        [SerializeField, BoxGroup("Movement")]
        private int _MovementSpeed = 100;
        #endregion Private Variables
    }
}