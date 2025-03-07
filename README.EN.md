# Sulfur ModCore API | 火湖模组API
![Version](https://img.shields.io/badge/version-0.2.19Alpha-blue)
[![BepInEx](https://img.shields.io/badge/BepInEx-5.4.21-green)](https://docs.bepinex.dev/)
![Support](https://img.shields.io/badge/support-ModdingCommunity-green)

## 🌍 Language | 语言 | 言語 | Langue
- [🇺🇸 English](README.EN.md)
- [🇨🇳 简体中文](README.md)

## 🔥 Introduction  
✨ **ModCore** provides **API interfaces** that allow other mods to integrate easily or serve as a reference for other mod developers. 🚧 Currently, it is in the improvement stage and being prepared for open-source release.  

🎯 **Main Features:**  
- ✅ Full item API and corresponding Sprite dictionary  
- ✅ Player event tracking  
- ✅ Map events  
- ✅ Loading events  
- ✅ Generation events  
- ✅ Collection of various Manager APIs  
- ✅ Player-related APIs  
- ✅ Damage events  
- ✅ Various interaction events  
- 📌 More to be added...  

## 📸 Preview  
![Image](https://github.com/user-attachments/assets/ec8f7b98-14e3-4478-a2dc-e4dc61fec605)  

## 🚀 Installation Guide  
To be added.  

## 🚧 Currently in Development  
- 🛠️ Completing known APIs  
- 🛠️ Adding event handlers  
- 🛠️ Improving documentation  
- 📌 More to be added...  

## 🤝 Contribution  
Feel free to submit PRs or Issues to improve this mod!  

📌 **Development Steps:**  
1. Fork this repository  
2. Clone your fork  
3. Create a new branch and make modifications  
4. Submit a PR 🎉  

## 🛠 API Overview  
### **Listening to Damage Events**  
```csharp
DamageAPI.OnBeforeDamage += (unit, ref float damage, ref DamageType type, ref DamageSourceData source, ref Hitbox hitbox, ref Vector3 point) =>
{
    if (unit == PlayerAPI.player) return false; // Prevent damage
    return true;
};



