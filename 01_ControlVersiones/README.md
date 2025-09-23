## COMANDOS DE GIT 

#### Comandos de Configuración
- git config --global user.name "Tu Nombre"
- git config --global user.email "tu@email.com"
- git config --global core.editor "code -wait"
- git config --list

#### Comandos Básicos de Repositorio
- git init                    # Inicializar repositorio
- git status                  # Ver estado de archivos
- git add archivo.txt         # Agregar archivo específico
- git add .                   # Agregar todos los archivos
- git commit -m "mensaje"     # Crear commit con mensaje
- git log                     # Ver historial de commits
- git log --oneline           # Ver historial resumido

#### Comandos de Repositorio Remoto
- git remote add origin [URL]    # Conectar con repositorio remoto
- git remote -v                  # Ver repositorios remotos
- git push origin main           # Subir cambios a GitHub
- git push -u origin main        # Primer push (establecer upstream)
- git pull origin main           # Descargar cambios de GitHub
- git clone [URL]                # Clonar repositorio existente

#### Comandos de Información
- git diff                    # Ver cambios no confirmados
- git diff --staged          # Ver cambios en staging
- git show                   # Ver último commit
- git branch                 # Ver ramas locales
- git branch -r              # Ver ramas remotas
