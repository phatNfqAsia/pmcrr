import React from 'react'
import Form, {
    FormHeader,
    FormSection,
    FormFooter,
    Field,
  } from '@atlaskit/form';
import Select from '@atlaskit/select';
import FieldText from '@atlaskit/field-text';
import Button from '@atlaskit/button';
import RadioGroup from '@atlaskit/radio'

function RegisterForm() {
    return (
        <Form>
            <FormHeader
                title="Register and join pmcrr"
            />
            <FormSection>
                <Field required>
                    <FieldText placeholder="Full name" />
                </Field>
                <Field required>
                    <FieldText placeholder="Email address" />
                </Field>
                <Field required>
                    <FieldText placeholder="Password" />
                </Field>
                <Field required>
                    <FieldText placeholder="Re-type password address" />
                </Field>
                <Field  isRequired label="Do you have a washing machine at home?">
                    <RadioGroup options={[
                        { name: 'haveWashingMachine', value: 1, label: 'Yes'},
                        { name: 'haveWashingMachine', value: 0, label: 'No'},
                    ]} />
                </Field>
                <Field  isRequired label="Do you handle your laundry by yourself?">
                    <RadioGroup options={[
                        { name: 'singleLaundry', value: 1, label: 'Yes'},
                        { name: 'singleLaundry', value: 0, label: 'No'},
                    ]} />
                </Field>

                <Select>
                    <option>1</option>
                    <option>2</option>
                </Select>
            </FormSection>
            <FormFooter>

            </FormFooter>
        </Form>
    )
}