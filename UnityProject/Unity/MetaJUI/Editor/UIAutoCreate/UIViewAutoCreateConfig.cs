using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XFramework.UI.Editor
{
    [Serializable]
    public class UIViewAutoCreateInfo
    {
        /// <summary>
        /// ������
        /// </summary>
        public string propName;

        /// <summary>
        /// �����
        /// </summary>
        public string comName;
    }
    [Serializable, CreateAssetMenu(menuName = "UI/CreateUIViewAutoCreateConfig")]
    public class UIViewAutoCreateConfig : ScriptableObject
    {
        public List<UIViewAutoCreateInfo> uiInfoList;
    }
}
