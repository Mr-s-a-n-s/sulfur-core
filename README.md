# Sulfur ModCore API | 火湖模组API
![Version](https://img.shields.io/badge/version-0.2.19Alpha-blue)
[![BepInEx](https://img.shields.io/badge/BepInEx-5.4.21-green)](https://docs.bepinex.dev/)
![Support](https://img.shields.io/badge/support-ModdingCommunity-green)

✨ **ModCore** 提供 **API 接口** 让其他 Mod 轻松集成或让其他Mod开发人员提供参考，目前正在完善阶段并为做开源做准备。  
🎯 **主要功能：**
- ✅ 监听大部分游戏常用的事件
- ✅ 提供游戏内的绝大部分API
- ✅ 玩家事件追踪
- 📌 待补充...

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
```

**其余待补充...**


