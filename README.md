# D2R Offline Backups

A simple CLI tool for backing up offline character files from Diablo II: Resurrected.

---

## ✅ Current Features

* Backup all offline character files
* Timestamped backup folders
* Simple CLI execution

---

## 🚧 Planned Features

* Limit number of backups (N retention)
* Archive old backups (zip)
* Detect game close and auto-backup
* GUI application (WinForms)

---

## 📁 Backup Location

Backups are stored in:

```
C:\Users\<YourUser>\D2R_Backups\
```

Each backup is stored in a timestamped folder.

---
## ⬇️ Download

Download the latest release here:

https://github.com/RollanParker/D2R_Offline_Backups/releases

## ▶️ Usage

Run the executable:


```
D2R_Offline_BackupsCLI.exe
```

(Optional) Limit number of backups:

```
D2R_Offline_BackupsCLI.exe 5
```

---

## ⚠️ Notes

* Only offline characters are supported
* Ensure the game is closed before running backups to avoid corruption

---

## 🧭 Project Goal

Build a reliable backup tool with:

* Automation
* Smart retention
* Simple GUI

---

## 🛠️ Tech Stack

* C#
* .NET
