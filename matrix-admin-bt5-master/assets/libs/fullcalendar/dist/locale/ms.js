!(function (e, a) {
  "object" == typeof exports && "object" == typeof module
    ? (module.exports = a(require("moment"), require("fullcalendar")))
    : "function" == typeof define && define.amd
    ? define(["moment", "fullcalendar"], a)
    : "object" == typeof exports
    ? a(require("moment"), require("fullcalendar"))
    : a(e.moment, e.FullCalendar);
})("undefined" != typeof self ? self : this, function (e, a) {
  return (function (e) {
    function a(n) {
      if (t[n]) return t[n].exports;
      var r = (t[n] = { i: n, l: !1, exports: {} });
      return e[n].call(r.exports, r, r.exports, a), (r.l = !0), r.exports;
    }
    var t = {};
    return (
      (a.m = e),
      (a.c = t),
      (a.d = function (e, t, n) {
        a.o(e, t) ||
          Object.defineProperty(e, t, {
            configurable: !1,
            enumerable: !0,
            get: n,
          });
      }),
      (a.n = function (e) {
        var t =
          e && e.__esModule
            ? function () {
                return e.default;
              }
            : function () {
                return e;
              };
        return a.d(t, "a", t), t;
      }),
      (a.o = function (e, a) {
        return Object.prototype.hasOwnProperty.call(e, a);
      }),
      (a.p = ""),
      a((a.s = 163))
    );
  })({
    0: function (a, t) {
      a.exports = e;
    },
    1: function (e, t) {
      e.exports = a;
    },
    163: function (e, a, t) {
      Object.defineProperty(a, "__esModule", { value: !0 }), t(164);
      var n = t(1);
      n.datepickerLocale("ms", "ms", {
        closeText: "Tutup",
        prevText: "&#x3C;Sebelum",
        nextText: "Selepas&#x3E;",
        currentText: "hari ini",
        monthNames: [
          "Januari",
          "Februari",
          "Mac",
          "April",
          "Mei",
          "Jun",
          "Julai",
          "Ogos",
          "September",
          "Oktober",
          "November",
          "Disember",
        ],
        monthNamesShort: [
          "Jan",
          "Feb",
          "Mac",
          "Apr",
          "Mei",
          "Jun",
          "Jul",
          "Ogo",
          "Sep",
          "Okt",
          "Nov",
          "Dis",
        ],
        dayNames: [
          "Ahad",
          "Isnin",
          "Selasa",
          "Rabu",
          "Khamis",
          "Jumaat",
          "Sabtu",
        ],
        dayNamesShort: ["Aha", "Isn", "Sel", "Rab", "kha", "Jum", "Sab"],
        dayNamesMin: ["Ah", "Is", "Se", "Ra", "Kh", "Ju", "Sa"],
        weekHeader: "Mg",
        dateFormat: "dd/mm/yy",
        firstDay: 0,
        isRTL: !1,
        showMonthAfterYear: !1,
        yearSuffix: "",
      }),
        n.locale("ms", {
          buttonText: {
            month: "Bulan",
            week: "Minggu",
            day: "Hari",
            list: "Agenda",
          },
          allDayText: "Sepanjang hari",
          eventLimitText: function (e) {
            return "masih ada " + e + " acara";
          },
          noEventsMessage: "Tiada peristiwa untuk dipaparkan",
        });
    },
    164: function (e, a, t) {
      !(function (e, a) {
        a(t(0));
      })(0, function (e) {
        return e.defineLocale("ms", {
          months:
            "Januari_Februari_Mac_April_Mei_Jun_Julai_Ogos_September_Oktober_November_Disember".split(
              "_"
            ),
          monthsShort: "Jan_Feb_Mac_Apr_Mei_Jun_Jul_Ogs_Sep_Okt_Nov_Dis".split(
            "_"
          ),
          weekdays: "Ahad_Isnin_Selasa_Rabu_Khamis_Jumaat_Sabtu".split("_"),
          weekdaysShort: "Ahd_Isn_Sel_Rab_Kha_Jum_Sab".split("_"),
          weekdaysMin: "Ah_Is_Sl_Rb_Km_Jm_Sb".split("_"),
          longDateFormat: {
            LT: "HH.mm",
            LTS: "HH.mm.ss",
            L: "DD/MM/YYYY",
            LL: "D MMMM YYYY",
            LLL: "D MMMM YYYY [pukul] HH.mm",
            LLLL: "dddd, D MMMM YYYY [pukul] HH.mm",
          },
          meridiemParse: /pagi|tengahari|petang|malam/,
          meridiemHour: function (e, a) {
            return (
              12 === e && (e = 0),
              "pagi" === a
                ? e
                : "tengahari" === a
                ? e >= 11
                  ? e
                  : e + 12
                : "petang" === a || "malam" === a
                ? e + 12
                : void 0
            );
          },
          meridiem: function (e, a, t) {
            return e < 11
              ? "pagi"
              : e < 15
              ? "tengahari"
              : e < 19
              ? "petang"
              : "malam";
          },
          calendar: {
            sameDay: "[Hari ini pukul] LT",
            nextDay: "[Esok pukul] LT",
            nextWeek: "dddd [pukul] LT",
            lastDay: "[Kelmarin pukul] LT",
            lastWeek: "dddd [lepas pukul] LT",
            sameElse: "L",
          },
          relativeTime: {
            future: "dalam %s",
            past: "%s yang lepas",
            s: "beberapa saat",
            ss: "%d saat",
            m: "seminit",
            mm: "%d minit",
            h: "sejam",
            hh: "%d jam",
            d: "sehari",
            dd: "%d hari",
            M: "sebulan",
            MM: "%d bulan",
            y: "setahun",
            yy: "%d tahun",
          },
          week: { dow: 1, doy: 7 },
        });
      });
    },
  });
});
