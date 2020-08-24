import { validateEmail } from './utils';

new Vue({
    el: '#form',
    data: {
        FullName: '',
        Email: '',
        Comments: '',
        InvalidEmail: false
    },
    computed: {
        isSubmitDisabled() {
            let isDisabled = true;

            if (
                this.FullName !== '' &&
                this.Email !== '' &&
                this.Comments !== ''
            ) {
                isDisabled = false;
            }

            return isDisabled;
        }
    },
    methods: {
        ResetForm() {
            this.FullName = '';
            this.Email = '';
            this.Comments = '';
        },
        SubmitForm() {
            let submit = true;

            if (!validateEmail(this.Email)) {
                this.InvalidEmail = true;
                submit = false;
            } else {
                this.InvalidEmail = false;
            }

            if (submit) {
                axios({
                    method: 'post',
                    url: 'api/v1/user',
                    data: { "Fields": this.$data }
                }).then(res => {
                    alert('Успешно сохранили!');
                    this.$refs.SubmitButton.setAttribute("disabled", "disabled");
                }).catch(err => {
                    alert(`Не удалось сохранить. Срочно набирай Феликсу: ${err}`);
                });
            }
        }
    }
});