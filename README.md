# Sulfur ModCore API | 火湖模组API
![Version](https://img.shields.io/badge/version-0.2.19Alpha-blue)
[![BepInEx](https://img.shields.io/badge/BepInEx-5.4.21-green)](https://docs.bepinex.dev/)
![Support](https://img.shields.io/badge/support-ModdingCommunity-green)

## 🌍 Language | 语言 | 言語 | Langue
- [🇺🇸 English](README.zh-CN.md)
- [🇨🇳 简体中文](README.md)

## 🔥 介绍
✨ **ModCore** 提供 **API 接口** 让其他 Mod 轻松集成或让其他Mod开发人员提供参考，🚧目前正在完善阶段并为做开源做准备。  
🎯 **主要功能：**
- ✅ 全物品API和对应的Sprite字典
- ✅ 玩家事件追踪
- ✅ 地图事件
- ✅ 载入事件
- ✅ 生成事件
- ✅ 各种Manager集合API
- ✅ 玩家相关API
- ✅ 伤害事件
- ✅ 各种交互事件
- 📌 待补充...

## 📸 预览
![Image](https://github.com/user-attachments/assets/ec8f7b98-14e3-4478-a2dc-e4dc61fec605)

## 🚀 安装指南
等待补充

## 🚧 目前正在施工
- 🛠️ 补全已知API
- 🛠️ 补全事件
- 🛠️ 补全开发文档
- 📌 待补充...

## 🤝 贡献
欢迎提交 PR 或 Issues 来改进这个 Mod！  
📌 **开发步骤**：
1. Fork 本仓库
2. Clone 你的 Fork
3. 创建新分支并进行修改
4. 提交 PR 🎉

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


