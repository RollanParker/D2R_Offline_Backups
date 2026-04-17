# Development Notes

## 🧠 Goals

* Reliable offline backup system
* Zero-risk rollback capability
* Eventually GUI-driven

---

## 🔧 Features (Planned)

### Core

* [ ] Max backup limit
* [ ] Archive old backups
* [ ] Detect game close

### GUI

* [ ] Backup Now button
* [ ] Toggle auto-backup
* [ ] Backup history view

---

## ⚠️ Considerations

* Delay after game close (~30s) to avoid corruption
* Ensure file locks are released
* Avoid duplicate backups if no changes

---

## 🧪 Ideas

* Hash files to detect changes
* Store metadata.json per backup
* Add logging system

---

## 📌 Questions

* Should backups be compressed by default?
* Should we support cloud sync later?

---

## 🧭 Architecture Direction

* CLI = core logic
* GUI = thin wrapper
* Eventually split into:

  * Core library
  * CLI
  * GUI
