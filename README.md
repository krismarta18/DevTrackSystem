# DevTrackSystem 🛠️
Sebuah aplikasi sederhana untuk mencatat perubahan selama proses development.

## Apa ini?
DevTrackSystem dibuat sebagai **alat bantu personal** bagi developer agar setiap perubahan dalam project (baik source code maupun database) bisa dicatat dengan rapi. Cocok digunakan saat ngembangin sistem, biar gak lupa udah ngoprek apa aja 😄

## Fitur utama
- Catat perubahan per project (berdasarkan pilihan dari file `project-list.txt`)
- Dukungan dua jenis perubahan:
  - 🧠 **Source Code**: nama file & catatan
  - 🗃️ **Database**: nama file, tipe (table, SP, atau query), dan catatan
- Disimpan otomatis dalam format JSON per project
- Jalan di background (tray icon)
- Auto-resize UI biar tetap rapi
- Bisa auto-start saat Windows boot

## Catatan penggunaan
- Tambahkan list project di file `project-list.txt`
  - Gunakan `*` di depan nama project untuk menjadikannya default
- File JSON hasil catatan akan disimpan otomatis di dalam folder `Catatan/`
- Aplikasi akan muncul di tray, dan bisa dibuka ulang via double click ikon-nya

## Boleh dipakai? 👀
Yup! **Boleh banget.**  
Boleh dipakai, dimodifikasi, dibagiin lagi, atau ditambahin fitur-fitur lain.

Tujuan utamanya cuma satu:  
> **Biar ngoding gak lupa udah ngapain.**

## Screenshot UI 
<img width="402" height="390" alt="image" src="https://github.com/user-attachments/assets/bd14a41d-1179-4087-a2bd-9aecd0ce878e" />
<img width="445" height="797" alt="image" src="https://github.com/user-attachments/assets/38459b72-ac69-4983-ac12-4899a94f6ac7" />
<img width="417" height="692" alt="image" src="https://github.com/user-attachments/assets/125484a8-89ae-47d6-8398-e99f4cb50401" />

## Screenshot Folder Publish 
<img width="1081" height="392" alt="image" src="https://github.com/user-attachments/assets/a7f01652-0f92-4f33-b404-a1d8142f9bfd" />

## 🧑‍💻 Sedikit catatan pribadi
Ini adalah **source code pertama** yang saya buat secara public di GitHub.  
Semoga bermanfaat buat kamu yang butuh catatan dev ringan tapi praktis.  
Kalau suka, boleh bintang ⭐ — kalau ada ide tambahan, feel free to pull request 🙏

Dibuat santai oleh dev yang suka lupa sendiri 😅  
Feel free to fork & improve!


