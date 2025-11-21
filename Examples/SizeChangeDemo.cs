/*
    Copyright (C) 2025  Alex Howe

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/
using TMPro;
using UnityEngine;

namespace Poke.UI
{
    public class SizeChangeDemo : MonoBehaviour
    {
        [SerializeField] private TMP_Text m_text;
        [SerializeField] private TMP_Text m_text2;
        [SerializeField] private float m_minSize = 12;
        [SerializeField] private float m_maxSize = 48;
        
        private void Update() {
            float t = Mathf.Sin(Time.unscaledTime) * 0.5f + 0.5f;
            float t2 = Mathf.Cos(Time.unscaledTime) * 0.5f + 0.5f;
            m_text.fontSize = Mathf.Lerp(m_minSize, m_maxSize, t);
            m_text2.fontSize = Mathf.Lerp(m_minSize, m_maxSize, t2);
        }
    }
}
