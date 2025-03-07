# Sulfur ModCore API | 火湖模组API
![Version](https://img.shields.io/badge/version-0.2.19Alpha-blue)
[![BepInEx](https://img.shields.io/badge/BepInEx-5.4.21-green)](https://docs.bepinex.dev/)
![Support](https://img.shields.io/badge/support-ModdingCommunity-green)

## 🔥 Introducción  
✨ **ModCore** proporciona **interfaces de API** que permiten a otros mods integrarse fácilmente o servir como referencia para otros desarrolladores de mods. 🚧 Actualmente, está en fase de mejora y preparación para su lanzamiento como código abierto.  

🎯 **Características principales:**  
- ✅ API completa de objetos y diccionario de Sprites correspondientes  
- ✅ Seguimiento de eventos del jugador  
- ✅ Eventos del mapa  
- ✅ Eventos de carga  
- ✅ Eventos de generación  
- ✅ Colección de varias APIs de administradores  
- ✅ APIs relacionadas con el jugador  
- ✅ Eventos de daño  
- ✅ Diversos eventos de interacción  
- 📌 Más por añadir...  

## 📸 Vista previa  
![Image](https://github.com/user-attachments/assets/ec8f7b98-14e3-4478-a2dc-e4dc61fec605)  

## 🚀 Guía de instalación  
Pendiente de añadir.  

## 🚧 En desarrollo  
- 🛠️ Completar las API conocidas  
- 🛠️ Añadir manejadores de eventos  
- 🛠️ Mejorar la documentación  
- 📌 Más por añadir...  

## 🤝 Contribución  
¡Siéntete libre de enviar PRs o Issues para mejorar este mod!  

📌 **Pasos para el desarrollo:**  
1. Haz un fork de este repositorio  
2. Clona tu fork  
3. Crea una nueva rama y realiza modificaciones  
4. Envía un PR 🎉  

## 🛠 Descripción de la API  
### **Escuchar eventos de daño**  
```csharp
DamageAPI.OnBeforeDamage += (unit, ref float damage, ref DamageType type, ref DamageSourceData source, ref Hitbox hitbox, ref Vector3 point) =>
{
    if (unit == PlayerAPI.player) return false; // Evitar el daño
    return true;
};
