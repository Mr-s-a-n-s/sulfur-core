# Sulfur ModCore API | Sulfur Mod API
![Version](https://img.shields.io/badge/version-0.3.6Alpha-blue)
[![BepInEx](https://img.shields.io/badge/BepInEx-5.4.21-green)](https://docs.bepinex.dev/)
![Support](https://img.shields.io/badge/support-ModdingCommunity-green)

## 🌍 Language | 语言 | 言語 | Langue
- [🇺🇸 English](README.EN.md)
- [🇨🇳 简体中文](README.md)
- [🇪🇸 Español](README.es.md)

## 🔥 Introduction
✨ **ModCore** provides an **API interface** that allows other mods to integrate easily or serve as a reference for other mod developers. 🚧 Currently under development.  
🎯 **Main Features:**
- ✅ Complete item and corresponding sprite dictionary
- ✅ Player event tracking
- ✅ Map events
- ✅ Loading events
- ✅ Generation events
- ✅ Various Manager collection APIs
- ✅ Player-related APIs
- ✅ Damage events
- ✅ Various interaction events
- 📌 More to be added...

## 📸 Preview
![Image](https://github.com/user-attachments/assets/e4e23bee-fd30-4c21-85ec-78261142eb42)

## 🚀 Installation Guide
Place `Mod.Core` into `\SULFUR\BepInEx\plugins`

## 🚧 Currently in Development
- 🛠️ Completing known APIs
- 🛠️ Implementing major events
- 🛠️ Finalizing documentation
- 📌 More to be added...

## 🤝 Contribution
PRs and Issues are welcome to improve this mod!  
📌 **Development Steps**:
1. Fork this repository
2. Clone your fork
3. Create a new branch and make modifications
4. Submit a PR 🎉

## 🛠 API Overview
**Listening to Damage Events**
```csharp
DamageAPI.OnBeforeDamage += (Unit unit, ref float damage, ref DamageType type, ref DamageSourceData source, ref Hitbox hitbox, ref Vector3 point) =>
{
    if (unit == PlayerAPI.uplayer) return false; // Prevent damage
    return true;
};
