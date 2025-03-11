# Sulfur ModCore API | 火湖模组API
![Version](https://img.shields.io/badge/version-0.3.6Alpha-blue)
[![BepInEx](https://img.shields.io/badge/BepInEx-5.4.21-green)](https://docs.bepinex.dev/)
![Support](https://img.shields.io/badge/support-ModdingCommunity-green)

## 🌍 Language | 语言 | 言語 | Langue
- [🇺🇸 English](README.EN.md)
- [🇨🇳 简体中文](README.md)
- [🇪🇸 Español](README.es.md)

## 🔥 Introducción
✨ **ModCore** proporciona una **interfaz API** que permite a otros mods integrarse fácilmente o servir como referencia para otros desarrolladores de mods. 🚧 Actualmente en desarrollo.  
🎯 **Características principales:**
- ✅ Diccionario completo de objetos y sus sprites correspondientes
- ✅ Seguimiento de eventos del jugador
- ✅ Eventos del mapa
- ✅ Eventos de carga
- ✅ Eventos de generación
- ✅ API de colecciones de varios Manager
- ✅ API relacionadas con el jugador
- ✅ Eventos de daño
- ✅ Varios eventos de interacción
- 📌 Más por agregar...

## 📸 Vista previa
![Image](https://github.com/user-attachments/assets/e4e23bee-fd30-4c21-85ec-78261142eb42)

## 🚀 Guía de instalación
Coloca `Mod.Core` en `\SULFUR\BepInEx\plugins`

## 🚧 Actualmente en desarrollo
- 🛠️ Completar las APIs conocidas
- 🛠️ Implementar los eventos principales
- 🛠️ Finalizar la documentación
- 📌 Más por agregar...

## 🤝 Contribución
¡Se aceptan PRs e Issues para mejorar este mod!  
📌 **Pasos para desarrollar**:
1. Haz un fork de este repositorio
2. Clona tu fork
3. Crea una nueva rama y realiza modificaciones
4. Envía un PR 🎉

## 🛠 Descripción de la API
**Escuchar eventos de daño**
```csharp
DamageAPI.OnBeforeDamage += (Unit unit, ref float damage, ref DamageType type, ref DamageSourceData source, ref Hitbox hitbox, ref Vector3 point) =>
{
    if (unit == PlayerAPI.uplayer) return false; // Prevenir el daño
    return true;
};
```
Comeing soon...
