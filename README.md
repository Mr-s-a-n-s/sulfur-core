# Sulfur ModCore API | 火湖模组API
![Version](https://img.shields.io/badge/version-0.2.19Alpha-blue)
[![BepInEx](https://img.shields.io/badge/BepInEx-5.4.21-green)](https://docs.bepinex.dev/)
![Support](https://img.shields.io/badge/support-ModdingCommunity-green)

✨ **ModCore** 是一个增强游戏体验的 Mod，提供 **API 接口** 让其他 Mod 轻松集成。  
🎯 **主要功能：**
- ✅ 伤害监听 API
- ✅ 物品管理 API
- ✅ UI 交互增强
- ✅ 玩家事件追踪

## 📸 预览
![Image](https://github.com/user-attachments/assets/ec8f7b98-14e3-4478-a2dc-e4dc61fec605)

## 🚀 安装指南
等待补充

## 🛠 API 介绍
**监听伤害事件**
```csharp
DamageAPI.OnBeforeDamage += (unit, ref float damage, ref DamageType type, ref DamageSourceData source, ref Hitbox hitbox, ref Vector3 point) =>
{
    if (unit == PlayerAPI.player) return false; // 阻止伤害
    return true;
};


