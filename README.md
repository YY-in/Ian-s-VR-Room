# Ian-s-VR-Room

## Features

### Room Design
- Designed room environment for VR experience

### Locomotion Systems
- **Turning Rig**: Enables user rotation in VR space
- **Teleporting Rig**: Allows instant movement to designated locations

## Locomotion Concepts

### Types of Locomotion
1. **Snap Turn**: Instant rotation by fixed angles (e.g., 30°, 45°)
   - Reduces motion sickness by avoiding smooth rotation
   - Provides quick directional changes

2. **Continuous Turn**: Smooth, gradual rotation
   - More natural feeling but can cause discomfort
   - Adjustable rotation speed

3. **Teleport**: Instant position change
   - Minimizes simulator sickness
   - Point-and-teleport interaction

### Vection and Simulator Sickness
- **Vection**: The sensation of self-motion induced by visual stimuli
- **Simulator Sickness**: Discomfort caused by mismatch between visual motion and physical stillness
- Mitigation strategies:
  - Use snap turning instead of continuous rotation
  - Implement teleportation for movement
  - Provide comfort options for users

### Teleportation Systems
- **Teleportation Areas**: Large designated zones where users can teleport freely within bounds
- **Teleportation Anchors**: Specific fixed points for precise teleportation destinations
